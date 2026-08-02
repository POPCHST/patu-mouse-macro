using System.Media;
using System.Runtime.InteropServices;

namespace MouseMacro;

public partial class Form1 : Form
{
    private enum MacroStatusKind
    {
        Idle,
        Running,
        Waiting,
        Error
    }

    private const int HotkeyStart = 1;
    private const int HotkeyStop = 2;
    private const int HotkeyCapture = 3;

    private const int JitterPercent = 15;

    private readonly System.Windows.Forms.Timer _clickTimer = new();
    private readonly System.Windows.Forms.Timer _waitTimer = new() { Interval = 1000 };
    private readonly List<MacroStep> _steps = new();
    private readonly Random _random = new();
    private PresenceCheckPoint? _presenceCheckPoint;
    private MacroStatusKind _statusKind = MacroStatusKind.Idle;
    private int _currentStepIndex;
    private int _completedPasses;
    private int _clicksDone;
    private bool _isRunning;

    public Form1()
    {
        InitializeComponent();
        Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath) ?? SystemIcons.Application;
        Text = $"{Text} v{Application.ProductVersion}";

        _clickTimer.Tick += ClickTimer_Tick;
        _waitTimer.Tick += WaitTimer_Tick;

        btnStart.Click += (_, _) => StartMacro();
        btnStop.Click += (_, _) => StopMacro();
        btnCapture.Click += (_, _) => CaptureAtCursor();
        btnHelp.Click += (_, _) => ShowHelp();
        cmbLanguage.SelectedIndexChanged += (_, _) => SetLanguageFromSelector();
        btnAddKeyStep.Click += (_, _) => AddKeyStep();
        btnRemoveStep.Click += (_, _) => RemoveSelectedStep();
        btnClearSteps.Click += (_, _) => ClearSteps();
        btnCapturePresence.Click += (_, _) => CapturePresencePoint();

        radFixedPos.CheckedChanged += UpdatePositionControlsEnabled;
        radRepeatCount.CheckedChanged += (_, _) => numRepeatCount.Enabled = radRepeatCount.Checked;

        UpdatePositionControlsEnabled(this, EventArgs.Empty);
        numRepeatCount.Enabled = radRepeatCount.Checked;

        FormClosing += (_, _) => StopMacro();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        NativeMethods.RegisterHotKey(Handle, HotkeyStart, NativeMethods.MOD_NONE, (uint)Keys.F6);
        NativeMethods.RegisterHotKey(Handle, HotkeyStop, NativeMethods.MOD_NONE, (uint)Keys.F7);
        NativeMethods.RegisterHotKey(Handle, HotkeyCapture, NativeMethods.MOD_NONE, (uint)Keys.F8);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        NativeMethods.UnregisterHotKey(Handle, HotkeyStart);
        NativeMethods.UnregisterHotKey(Handle, HotkeyStop);
        NativeMethods.UnregisterHotKey(Handle, HotkeyCapture);
        base.OnFormClosed(e);
    }

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == NativeMethods.WM_HOTKEY)
        {
            switch (m.WParam.ToInt32())
            {
                case HotkeyStart:
                    StartMacro();
                    break;
                case HotkeyStop:
                    StopMacro();
                    break;
                case HotkeyCapture:
                    CaptureAtCursor();
                    break;
            }
        }

        base.WndProc(ref m);
    }

    private void ShowHelp()
    {
        using var help = new HelpForm();
        help.ShowDialog(this);
    }

    private void SetLanguageFromSelector()
    {
        Strings.Current = cmbLanguage.SelectedIndex switch
        {
            1 => AppLanguage.English,
            2 => AppLanguage.Chinese,
            _ => AppLanguage.Thai
        };
        ApplyLanguage();
    }

    private void ApplyLanguage()
    {
        btnHelp.Text = Strings.HelpButton;

        tabClick.Text = Strings.TabClick;
        tabSettings.Text = Strings.TabSettings;
        tabPresence.Text = Strings.TabPresence;

        grpMode.Text = Strings.ModeGroupTitle;
        radCurrentPos.Text = Strings.ModeCurrentPos;
        radFixedPos.Text = Strings.ModeFixedPos;

        grpSequence.Text = Strings.SequenceGroupTitle;
        btnCapture.Text = Strings.CaptureButton;
        lblStepDelay.Text = Strings.StepDelayLabel;
        lblKeyPress.Text = Strings.KeyPressLabel;
        btnAddKeyStep.Text = Strings.AddKeyStepButton;
        btnRemoveStep.Text = Strings.RemoveStepButton;
        btnClearSteps.Text = Strings.ClearStepsButton;

        grpClick.Text = Strings.ClickSettingsGroupTitle;
        lblButton.Text = Strings.MouseButtonLabel;
        var selectedButtonIndex = cmbButton.SelectedIndex < 0 ? 0 : cmbButton.SelectedIndex;
        cmbButton.Items.Clear();
        cmbButton.Items.AddRange(Strings.MouseButtonItems);
        cmbButton.SelectedIndex = selectedButtonIndex;
        lblInterval.Text = Strings.IntervalLabel;
        lblIntervalHint.Text = Strings.IntervalHint;
        chkJitter.Text = Strings.JitterCheckbox;

        grpRepeat.Text = Strings.RepeatGroupTitle;
        radRepeatForever.Text = Strings.RepeatForever;
        radRepeatCount.Text = Strings.RepeatCount;
        lblTimes.Text = Strings.RoundsLabel;

        lblPresenceHint.Text = Strings.PresenceGroupTitle;
        btnCapturePresence.Text = Strings.CapturePresenceButton;
        lblPresenceInfo.Text = _presenceCheckPoint is null
            ? Strings.PresenceNotSet
            : Strings.PresenceSet(_presenceCheckPoint.TargetTitle);
        chkWaitForPlayer.Text = Strings.WaitForPlayerCheckbox;

        lblClickCount.Text = Strings.ActionsDone(_clicksDone);
        btnStart.Text = Strings.StartButton;
        btnStop.Text = Strings.StopButton;
        lblHotkeyInfo.Text = Strings.HotkeyInfo;

        RenderStatus();
        RefreshStepList();
    }

    private void SetStatus(MacroStatusKind kind)
    {
        _statusKind = kind;
        RenderStatus();
    }

    private void RenderStatus()
    {
        switch (_statusKind)
        {
            case MacroStatusKind.Running:
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = Strings.StatusRunning;
                break;
            case MacroStatusKind.Waiting:
                lblStatus.ForeColor = Color.DarkOrange;
                lblStatus.Text = Strings.StatusWaiting;
                break;
            case MacroStatusKind.Error:
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = Strings.StatusError;
                break;
            default:
                lblStatus.ForeColor = SystemColors.ControlText;
                lblStatus.Text = Strings.StatusStopped;
                break;
        }
    }

    private void CaptureAtCursor()
    {
        var captured = MacroTarget.CaptureAt(Cursor.Position);
        if (captured is null)
        {
            lblStepCount.Text = Strings.CaptureFailed;
            return;
        }

        _steps.Add(new MacroStep { ActionType = StepActionType.Click, Target = captured, DelayMs = (int)numStepDelay.Value });
        RefreshStepList();

        radFixedPos.Checked = true;
    }

    private void AddKeyStep()
    {
        var key = ParseSelectedKey((string)cmbKeyToPress.SelectedItem!);
        _steps.Add(new MacroStep { ActionType = StepActionType.KeyPress, Key = key, DelayMs = (int)numStepDelay.Value });
        RefreshStepList();

        radFixedPos.Checked = true;
    }

    private static Keys ParseSelectedKey(string text) => text switch
    {
        "Enter" => Keys.Enter,
        "Space" => Keys.Space,
        "Esc" => Keys.Escape,
        "Tab" => Keys.Tab,
        _ => Enum.Parse<Keys>(text)
    };

    private void CapturePresencePoint()
    {
        var captured = MacroTarget.CaptureAt(Cursor.Position);
        if (captured is null || !captured.TryResolveScreenPosition(out var screenPosition))
        {
            lblPresenceInfo.Text = Strings.CaptureFailed;
            return;
        }

        var baselineColor = PixelSampler.GetPixelColor(screenPosition);
        _presenceCheckPoint = new PresenceCheckPoint(captured, baselineColor);
        lblPresenceInfo.Text = Strings.PresenceSet(captured.Title);
    }

    private void RemoveSelectedStep()
    {
        if (lstSteps.SelectedIndex < 0)
        {
            return;
        }

        _steps.RemoveAt(lstSteps.SelectedIndex);
        RefreshStepList();
    }

    private void ClearSteps()
    {
        _steps.Clear();
        RefreshStepList();
    }

    private void RefreshStepList()
    {
        lstSteps.Items.Clear();
        foreach (var step in _steps)
        {
            lstSteps.Items.Add(step.ToString()!);
        }

        lblStepCount.Text = Strings.TotalPoints(_steps.Count);
    }

    private void UpdatePositionControlsEnabled(object? sender, EventArgs e)
    {
        var fixedMode = radFixedPos.Checked;
        btnCapture.Enabled = fixedMode;
        numStepDelay.Enabled = fixedMode;
        cmbKeyToPress.Enabled = fixedMode;
        btnAddKeyStep.Enabled = fixedMode;
        lstSteps.Enabled = fixedMode;
        btnRemoveStep.Enabled = fixedMode;
        btnClearSteps.Enabled = fixedMode;
    }

    private void StartMacro()
    {
        if (_isRunning)
        {
            return;
        }

        if (radFixedPos.Checked && _steps.Count == 0)
        {
            lblStepCount.Text = Strings.NeedStepsFirst;
            return;
        }

        if (chkWaitForPlayer.Checked && _presenceCheckPoint is null)
        {
            lblPresenceInfo.Text = Strings.NeedPresencePointFirst;
            return;
        }

        _isRunning = true;
        btnStart.Enabled = false;
        btnStop.Enabled = true;

        if (chkWaitForPlayer.Checked && !_presenceCheckPoint!.HasPlayerJoined())
        {
            SetStatus(MacroStatusKind.Waiting);
            _waitTimer.Start();
            return;
        }

        BeginClicking();
    }

    private void WaitTimer_Tick(object? sender, EventArgs e)
    {
        if (!_presenceCheckPoint!.HasPlayerJoined())
        {
            return;
        }

        _waitTimer.Stop();
        BeginClicking();
    }

    private void BeginClicking()
    {
        _clicksDone = 0;
        _currentStepIndex = 0;
        _completedPasses = 0;
        _clickTimer.Interval = GetNextIntervalMs(radFixedPos.Checked ? _steps[0].DelayMs : (int)numInterval.Value);
        _clickTimer.Start();
        SetStatus(MacroStatusKind.Running);
        lblClickCount.Text = Strings.ActionsDone(0);
    }

    private void StopMacro(bool isError = false)
    {
        if (!_isRunning)
        {
            return;
        }

        _isRunning = false;
        _clickTimer.Stop();
        _waitTimer.Stop();
        btnStart.Enabled = true;
        btnStop.Enabled = false;

        if (isError)
        {
            SetStatus(MacroStatusKind.Error);
            FlashTaskbar();
            SystemSounds.Exclamation.Play();
        }
        else
        {
            SetStatus(MacroStatusKind.Idle);
        }
    }

    private void FlashTaskbar()
    {
        var info = new NativeMethods.FLASHWINFO
        {
            hwnd = Handle,
            dwFlags = NativeMethods.FLASHW_ALL | NativeMethods.FLASHW_TIMERNOFG,
            uCount = uint.MaxValue,
            dwTimeout = 0
        };
        info.cbSize = (uint)Marshal.SizeOf(info);
        NativeMethods.FlashWindowEx(ref info);
    }

    private void ClickTimer_Tick(object? sender, EventArgs e)
    {
        int delayForNextTick;

        if (radFixedPos.Checked)
        {
            var step = _steps[_currentStepIndex];

            if (step.ActionType == StepActionType.KeyPress)
            {
                KeyboardSender.PressKey(step.Key);
            }
            else if (step.Target!.TryResolveScreenPosition(out var position))
            {
                MouseClicker.ClickAt(position, GetSelectedButton());
            }
            else
            {
                StopMacro(isError: true);
                return;
            }

            delayForNextTick = step.DelayMs;
        }
        else
        {
            MouseClicker.ClickAt(Cursor.Position, GetSelectedButton());
            delayForNextTick = (int)numInterval.Value;
        }

        _clicksDone++;
        lblClickCount.Text = Strings.ActionsDone(_clicksDone);

        if (radFixedPos.Checked)
        {
            _currentStepIndex++;
            if (_currentStepIndex >= _steps.Count)
            {
                _currentStepIndex = 0;
                _completedPasses++;

                if (radRepeatCount.Checked && _completedPasses >= numRepeatCount.Value)
                {
                    StopMacro();
                    return;
                }
            }
        }
        else if (radRepeatCount.Checked && _clicksDone >= numRepeatCount.Value)
        {
            StopMacro();
            return;
        }

        _clickTimer.Interval = GetNextIntervalMs(delayForNextTick);
    }

    private MouseButtonType GetSelectedButton() => cmbButton.SelectedIndex switch
    {
        1 => MouseButtonType.Right,
        2 => MouseButtonType.Middle,
        _ => MouseButtonType.Left
    };

    private int GetNextIntervalMs(int baseMs)
    {
        if (!chkJitter.Checked)
        {
            return baseMs;
        }

        var variation = Math.Max(1, baseMs * JitterPercent / 100);
        var jittered = baseMs + _random.Next(-variation, variation + 1);
        return Math.Max(10, jittered);
    }
}
