namespace MouseMacro;

public partial class Form1 : Form
{
    private const int HotkeyStart = 1;
    private const int HotkeyStop = 2;
    private const int HotkeyCapture = 3;

    private const int JitterPercent = 15;

    private readonly System.Windows.Forms.Timer _clickTimer = new();
    private readonly MacroTarget _target = new();
    private readonly Random _random = new();
    private int _clicksDone;
    private bool _isRunning;
    private bool _suppressPercentEvents;

    public Form1()
    {
        InitializeComponent();
        Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath) ?? SystemIcons.Application;

        _clickTimer.Tick += ClickTimer_Tick;

        btnStart.Click += (_, _) => StartMacro();
        btnStop.Click += (_, _) => StopMacro();
        btnCapture.Click += (_, _) => CaptureAtCursor();
        btnHelp.Click += (_, _) => ShowHelp();

        radFixedPos.CheckedChanged += UpdatePositionControlsEnabled;
        radRepeatCount.CheckedChanged += (_, _) => numRepeatCount.Enabled = radRepeatCount.Checked;
        numX.ValueChanged += (_, _) => ApplyManualPercentEdit();
        numY.ValueChanged += (_, _) => ApplyManualPercentEdit();

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

    private void CaptureAtCursor()
    {
        var captured = MacroTarget.CaptureAt(Cursor.Position);
        if (captured is null)
        {
            lblTargetInfo.Text = "จับตำแหน่งไม่สำเร็จ ลองเอาเมาส์ไปชี้ในหน้าต่างเกมแล้วกด F8 อีกครั้ง";
            return;
        }

        _target.CopyHandleFrom(captured);
        _target.SetRelative(captured.RelativeX, captured.RelativeY);

        _suppressPercentEvents = true;
        numX.Value = (decimal)Math.Clamp(captured.RelativeX * 100, 0, 100);
        numY.Value = (decimal)Math.Clamp(captured.RelativeY * 100, 0, 100);
        _suppressPercentEvents = false;

        radFixedPos.Checked = true;
        lblTargetInfo.Text = $"เป้าหมาย: \"{captured.Title}\" ที่ตำแหน่ง {captured.RelativeX * 100:0.0}%, {captured.RelativeY * 100:0.0}% ของหน้าต่าง";
    }

    private void ApplyManualPercentEdit()
    {
        if (_suppressPercentEvents || !_target.IsCaptured)
        {
            return;
        }

        _target.SetRelative((double)(numX.Value / 100m), (double)(numY.Value / 100m));
    }

    private void UpdatePositionControlsEnabled(object? sender, EventArgs e)
    {
        var fixedMode = radFixedPos.Checked;
        numX.Enabled = fixedMode;
        numY.Enabled = fixedMode;
        btnCapture.Enabled = fixedMode;
    }

    private void StartMacro()
    {
        if (_isRunning)
        {
            return;
        }

        if (radFixedPos.Checked && !_target.IsCaptured)
        {
            lblTargetInfo.Text = "กรุณาจับตำแหน่งก่อน (เอาเมาส์ชี้ปุ่มในเกม แล้วกด F8)";
            return;
        }

        _isRunning = true;
        _clicksDone = 0;
        _clickTimer.Interval = GetNextIntervalMs();
        _clickTimer.Start();
        lblStatus.Text = "สถานะ: กำลังทำงาน...";
        lblClickCount.Text = "จำนวนคลิก: 0";
        btnStart.Enabled = false;
        btnStop.Enabled = true;
    }

    private void StopMacro()
    {
        if (!_isRunning)
        {
            return;
        }

        _isRunning = false;
        _clickTimer.Stop();
        lblStatus.Text = "สถานะ: หยุดแล้ว";
        btnStart.Enabled = true;
        btnStop.Enabled = false;
    }

    private void ClickTimer_Tick(object? sender, EventArgs e)
    {
        Point position;

        if (radFixedPos.Checked)
        {
            if (!_target.TryResolveScreenPosition(out position))
            {
                StopMacro();
                lblStatus.Text = "หยุดทำงาน: ไม่พบหน้าต่างเกมที่จับตำแหน่งไว้ (ปิดไปแล้ว?)";
                return;
            }
        }
        else
        {
            position = Cursor.Position;
        }

        var button = cmbButton.SelectedIndex switch
        {
            1 => MouseButtonType.Right,
            2 => MouseButtonType.Middle,
            _ => MouseButtonType.Left
        };

        MouseClicker.ClickAt(position, button);
        _clicksDone++;
        lblClickCount.Text = $"จำนวนคลิก: {_clicksDone}";

        if (radRepeatCount.Checked && _clicksDone >= numRepeatCount.Value)
        {
            StopMacro();
            return;
        }

        _clickTimer.Interval = GetNextIntervalMs();
    }

    private int GetNextIntervalMs()
    {
        var baseMs = (int)numInterval.Value;
        if (!chkJitter.Checked)
        {
            return baseMs;
        }

        var variation = Math.Max(1, baseMs * JitterPercent / 100);
        var jittered = baseMs + _random.Next(-variation, variation + 1);
        return Math.Max((int)numInterval.Minimum, jittered);
    }
}
