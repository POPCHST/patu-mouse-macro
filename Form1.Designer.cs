namespace MouseMacro;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private ComboBox cmbLanguage;
    private Button btnHelp;

    private TabControl tabControl;
    private TabPage tabClick;
    private TabPage tabSettings;
    private TabPage tabPresence;

    private GroupBox grpMode;
    private RadioButton radCurrentPos;
    private RadioButton radFixedPos;

    private GroupBox grpSequence;
    private Button btnCapture;
    private Label lblStepDelay;
    private NumericUpDown numStepDelay;
    private Label lblKeyPress;
    private ComboBox cmbKeyToPress;
    private Button btnAddKeyStep;
    private ListBox lstSteps;
    private Button btnRemoveStep;
    private Button btnClearSteps;
    private Label lblStepCount;

    private GroupBox grpClick;
    private Label lblButton;
    private ComboBox cmbButton;
    private Label lblInterval;
    private NumericUpDown numInterval;
    private Label lblIntervalHint;
    private CheckBox chkJitter;

    private GroupBox grpRepeat;
    private RadioButton radRepeatForever;
    private RadioButton radRepeatCount;
    private NumericUpDown numRepeatCount;
    private Label lblTimes;

    private Label lblPresenceHint;
    private Button btnCapturePresence;
    private Label lblPresenceInfo;
    private CheckBox chkWaitForPlayer;

    private Label lblStatus;
    private Label lblClickCount;
    private Button btnStart;
    private Button btnStop;
    private Label lblHotkeyInfo;

    private static readonly Color AccentBlue = Color.FromArgb(79, 142, 247);
    private static readonly Color AccentGreen = Color.FromArgb(52, 199, 89);
    private static readonly Color AccentRed = Color.FromArgb(255, 59, 48);
    private static readonly Color NeutralGray = Color.FromArgb(233, 236, 241);
    private static readonly Color PageBackground = Color.FromArgb(247, 248, 250);

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        cmbLanguage = new ComboBox();
        btnHelp = new Button();

        tabControl = new TabControl();
        tabClick = new TabPage();
        tabSettings = new TabPage();
        tabPresence = new TabPage();

        grpMode = new GroupBox();
        radCurrentPos = new RadioButton();
        radFixedPos = new RadioButton();

        grpSequence = new GroupBox();
        btnCapture = new Button();
        lblStepDelay = new Label();
        numStepDelay = new NumericUpDown();
        lblKeyPress = new Label();
        cmbKeyToPress = new ComboBox();
        btnAddKeyStep = new Button();
        lstSteps = new ListBox();
        btnRemoveStep = new Button();
        btnClearSteps = new Button();
        lblStepCount = new Label();

        grpClick = new GroupBox();
        lblButton = new Label();
        cmbButton = new ComboBox();
        lblInterval = new Label();
        numInterval = new NumericUpDown();
        lblIntervalHint = new Label();
        chkJitter = new CheckBox();

        grpRepeat = new GroupBox();
        radRepeatForever = new RadioButton();
        radRepeatCount = new RadioButton();
        numRepeatCount = new NumericUpDown();
        lblTimes = new Label();

        lblPresenceHint = new Label();
        btnCapturePresence = new Button();
        lblPresenceInfo = new Label();
        chkWaitForPlayer = new CheckBox();

        lblStatus = new Label();
        lblClickCount = new Label();
        btnStart = new Button();
        btnStop = new Button();
        lblHotkeyInfo = new Label();

        tabControl.SuspendLayout();
        tabClick.SuspendLayout();
        tabSettings.SuspendLayout();
        tabPresence.SuspendLayout();
        grpMode.SuspendLayout();
        grpSequence.SuspendLayout();
        grpClick.SuspendLayout();
        grpRepeat.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numStepDelay).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numRepeatCount).BeginInit();
        SuspendLayout();

        // cmbLanguage
        cmbLanguage.Location = new Point(12, 10);
        cmbLanguage.Size = new Size(112, 28);
        cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbLanguage.Items.AddRange(new object[] { "ไทย", "English", "中文" });
        cmbLanguage.SelectedIndex = 0;

        // btnHelp
        StyleFlatButton(btnHelp, NeutralGray, Color.Black);
        btnHelp.Text = Strings.HelpButton;
        btnHelp.Location = new Point(332, 10);
        btnHelp.Size = new Size(96, 28);

        // tabControl
        tabControl.Location = new Point(12, 48);
        tabControl.Size = new Size(416, 386);
        tabControl.Controls.Add(tabClick);
        tabControl.Controls.Add(tabSettings);
        tabControl.Controls.Add(tabPresence);

        // tabClick
        tabClick.Text = Strings.TabClick;
        tabClick.UseVisualStyleBackColor = true;
        tabClick.Padding = new Padding(10);
        tabClick.Controls.Add(grpMode);
        tabClick.Controls.Add(grpSequence);

        // grpMode
        grpMode.Text = Strings.ModeGroupTitle;
        grpMode.Location = new Point(10, 10);
        grpMode.Size = new Size(388, 72);
        grpMode.Controls.Add(radCurrentPos);
        grpMode.Controls.Add(radFixedPos);

        // radCurrentPos
        radCurrentPos.Text = Strings.ModeCurrentPos;
        radCurrentPos.Location = new Point(13, 22);
        radCurrentPos.Size = new Size(362, 20);
        radCurrentPos.Checked = true;

        // radFixedPos
        radFixedPos.Text = Strings.ModeFixedPos;
        radFixedPos.Location = new Point(13, 46);
        radFixedPos.Size = new Size(362, 20);

        // grpSequence
        grpSequence.Text = Strings.SequenceGroupTitle;
        grpSequence.Location = new Point(10, 90);
        grpSequence.Size = new Size(388, 246);
        grpSequence.Controls.Add(btnCapture);
        grpSequence.Controls.Add(lblStepDelay);
        grpSequence.Controls.Add(numStepDelay);
        grpSequence.Controls.Add(lblKeyPress);
        grpSequence.Controls.Add(cmbKeyToPress);
        grpSequence.Controls.Add(btnAddKeyStep);
        grpSequence.Controls.Add(lstSteps);
        grpSequence.Controls.Add(btnRemoveStep);
        grpSequence.Controls.Add(btnClearSteps);
        grpSequence.Controls.Add(lblStepCount);

        // btnCapture
        StyleFlatButton(btnCapture, AccentBlue, Color.White);
        btnCapture.Text = Strings.CaptureButton;
        btnCapture.Location = new Point(13, 22);
        btnCapture.Size = new Size(362, 32);
        btnCapture.Enabled = false;

        // lblStepDelay
        lblStepDelay.Text = Strings.StepDelayLabel;
        lblStepDelay.Location = new Point(13, 60);
        lblStepDelay.Size = new Size(150, 20);
        lblStepDelay.TextAlign = ContentAlignment.MiddleLeft;

        // numStepDelay
        numStepDelay.Location = new Point(168, 57);
        numStepDelay.Size = new Size(95, 23);
        numStepDelay.Minimum = 10;
        numStepDelay.Maximum = 600000;
        numStepDelay.Value = 1000;
        numStepDelay.ThousandsSeparator = true;

        // lblKeyPress
        lblKeyPress.Text = Strings.KeyPressLabel;
        lblKeyPress.Location = new Point(13, 90);
        lblKeyPress.Size = new Size(100, 20);
        lblKeyPress.TextAlign = ContentAlignment.MiddleLeft;

        // cmbKeyToPress
        cmbKeyToPress.Location = new Point(113, 87);
        cmbKeyToPress.Size = new Size(85, 23);
        cmbKeyToPress.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbKeyToPress.Items.AddRange(new object[] { "Enter", "F5", "F1", "F2", "F3", "F4", "F9", "F10", "F11", "F12", "Space", "Esc", "Tab" });
        cmbKeyToPress.SelectedIndex = 0;

        // btnAddKeyStep
        StyleFlatButton(btnAddKeyStep, NeutralGray, Color.Black);
        btnAddKeyStep.Text = Strings.AddKeyStepButton;
        btnAddKeyStep.Location = new Point(203, 86);
        btnAddKeyStep.Size = new Size(172, 25);

        // lstSteps
        lstSteps.Location = new Point(13, 118);
        lstSteps.Size = new Size(362, 80);
        lstSteps.IntegralHeight = false;

        // btnRemoveStep
        StyleFlatButton(btnRemoveStep, NeutralGray, Color.Black);
        btnRemoveStep.Text = Strings.RemoveStepButton;
        btnRemoveStep.Location = new Point(13, 204);
        btnRemoveStep.Size = new Size(115, 26);

        // btnClearSteps
        StyleFlatButton(btnClearSteps, NeutralGray, Color.Black);
        btnClearSteps.Text = Strings.ClearStepsButton;
        btnClearSteps.Location = new Point(136, 204);
        btnClearSteps.Size = new Size(95, 26);

        // lblStepCount
        lblStepCount.Text = Strings.TotalPoints(0);
        lblStepCount.Location = new Point(237, 208);
        lblStepCount.Size = new Size(138, 20);
        lblStepCount.ForeColor = Color.DimGray;
        lblStepCount.TextAlign = ContentAlignment.MiddleRight;

        // tabSettings
        tabSettings.Text = Strings.TabSettings;
        tabSettings.UseVisualStyleBackColor = true;
        tabSettings.Padding = new Padding(10);
        tabSettings.Controls.Add(grpClick);
        tabSettings.Controls.Add(grpRepeat);

        // grpClick
        grpClick.Text = Strings.ClickSettingsGroupTitle;
        grpClick.Location = new Point(10, 10);
        grpClick.Size = new Size(388, 140);
        grpClick.Controls.Add(lblButton);
        grpClick.Controls.Add(cmbButton);
        grpClick.Controls.Add(lblInterval);
        grpClick.Controls.Add(numInterval);
        grpClick.Controls.Add(lblIntervalHint);
        grpClick.Controls.Add(chkJitter);

        // lblButton
        lblButton.Text = Strings.MouseButtonLabel;
        lblButton.Location = new Point(13, 25);
        lblButton.Size = new Size(80, 20);
        lblButton.TextAlign = ContentAlignment.MiddleLeft;

        // cmbButton
        cmbButton.Location = new Point(100, 22);
        cmbButton.Size = new Size(130, 23);
        cmbButton.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbButton.Items.AddRange(Strings.MouseButtonItems);
        cmbButton.SelectedIndex = 0;

        // lblInterval
        lblInterval.Text = Strings.IntervalLabel;
        lblInterval.Location = new Point(13, 53);
        lblInterval.Size = new Size(80, 20);
        lblInterval.TextAlign = ContentAlignment.MiddleLeft;

        // numInterval
        numInterval.Location = new Point(100, 50);
        numInterval.Size = new Size(100, 23);
        numInterval.Minimum = 10;
        numInterval.Maximum = 600000;
        numInterval.Value = 1000;
        numInterval.ThousandsSeparator = true;

        // lblIntervalHint
        lblIntervalHint.Text = Strings.IntervalHint;
        lblIntervalHint.Location = new Point(13, 78);
        lblIntervalHint.Size = new Size(362, 32);
        lblIntervalHint.ForeColor = Color.Gray;

        // chkJitter
        chkJitter.Text = Strings.JitterCheckbox;
        chkJitter.Location = new Point(13, 114);
        chkJitter.Size = new Size(362, 20);
        chkJitter.Checked = true;

        // grpRepeat
        grpRepeat.Text = Strings.RepeatGroupTitle;
        grpRepeat.Location = new Point(10, 158);
        grpRepeat.Size = new Size(388, 72);
        grpRepeat.Controls.Add(radRepeatForever);
        grpRepeat.Controls.Add(radRepeatCount);
        grpRepeat.Controls.Add(numRepeatCount);
        grpRepeat.Controls.Add(lblTimes);

        // radRepeatForever
        radRepeatForever.Text = Strings.RepeatForever;
        radRepeatForever.Location = new Point(13, 20);
        radRepeatForever.Size = new Size(300, 20);
        radRepeatForever.Checked = true;

        // radRepeatCount
        radRepeatCount.Text = Strings.RepeatCount;
        radRepeatCount.Location = new Point(13, 43);
        radRepeatCount.Size = new Size(140, 20);

        // numRepeatCount
        numRepeatCount.Location = new Point(158, 41);
        numRepeatCount.Size = new Size(80, 23);
        numRepeatCount.Minimum = 1;
        numRepeatCount.Maximum = 1000000;
        numRepeatCount.Value = 10;
        numRepeatCount.Enabled = false;

        // lblTimes
        lblTimes.Text = Strings.RoundsLabel;
        lblTimes.Location = new Point(243, 43);
        lblTimes.Size = new Size(40, 20);
        lblTimes.TextAlign = ContentAlignment.MiddleLeft;

        // tabPresence
        tabPresence.Text = Strings.TabPresence;
        tabPresence.UseVisualStyleBackColor = true;
        tabPresence.Padding = new Padding(10);
        tabPresence.Controls.Add(lblPresenceHint);
        tabPresence.Controls.Add(btnCapturePresence);
        tabPresence.Controls.Add(lblPresenceInfo);
        tabPresence.Controls.Add(chkWaitForPlayer);

        // lblPresenceHint
        lblPresenceHint.Text = Strings.PresenceGroupTitle;
        lblPresenceHint.Location = new Point(13, 10);
        lblPresenceHint.Size = new Size(362, 20);
        lblPresenceHint.Font = new Font(Font, FontStyle.Bold);

        // btnCapturePresence
        StyleFlatButton(btnCapturePresence, AccentBlue, Color.White);
        btnCapturePresence.Text = Strings.CapturePresenceButton;
        btnCapturePresence.Location = new Point(13, 40);
        btnCapturePresence.Size = new Size(362, 32);

        // lblPresenceInfo
        lblPresenceInfo.Text = Strings.PresenceNotSet;
        lblPresenceInfo.Location = new Point(13, 78);
        lblPresenceInfo.Size = new Size(362, 20);
        lblPresenceInfo.ForeColor = Color.DimGray;

        // chkWaitForPlayer
        chkWaitForPlayer.Text = Strings.WaitForPlayerCheckbox;
        chkWaitForPlayer.Location = new Point(13, 100);
        chkWaitForPlayer.Size = new Size(362, 20);

        // lblStatus
        lblStatus.Text = Strings.StatusIdle;
        lblStatus.Location = new Point(15, 444);
        lblStatus.Size = new Size(400, 20);
        lblStatus.Font = new Font(Font, FontStyle.Bold);

        // lblClickCount
        lblClickCount.Text = Strings.ActionsDone(0);
        lblClickCount.Location = new Point(15, 466);
        lblClickCount.Size = new Size(400, 20);

        // btnStart
        StyleFlatButton(btnStart, AccentGreen, Color.White);
        btnStart.Text = Strings.StartButton;
        btnStart.Location = new Point(15, 494);
        btnStart.Size = new Size(196, 44);
        btnStart.Font = new Font(Font.FontFamily, 11f, FontStyle.Bold);

        // btnStop
        StyleFlatButton(btnStop, AccentRed, Color.White);
        btnStop.Text = Strings.StopButton;
        btnStop.Location = new Point(221, 494);
        btnStop.Size = new Size(196, 44);
        btnStop.Enabled = false;
        btnStop.Font = new Font(Font.FontFamily, 11f, FontStyle.Bold);

        // lblHotkeyInfo
        lblHotkeyInfo.Text = Strings.HotkeyInfo;
        lblHotkeyInfo.Location = new Point(15, 546);
        lblHotkeyInfo.Size = new Size(400, 20);
        lblHotkeyInfo.ForeColor = Color.Gray;

        // Form1
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Tahoma", 9f);
        BackColor = PageBackground;
        ClientSize = new Size(440, 580);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "patu.v1-mouse-macro";
        Controls.Add(cmbLanguage);
        Controls.Add(btnHelp);
        Controls.Add(tabControl);
        Controls.Add(lblStatus);
        Controls.Add(lblClickCount);
        Controls.Add(btnStart);
        Controls.Add(btnStop);
        Controls.Add(lblHotkeyInfo);

        tabControl.ResumeLayout(false);
        tabClick.ResumeLayout(false);
        tabSettings.ResumeLayout(false);
        tabPresence.ResumeLayout(false);
        grpMode.ResumeLayout(false);
        grpSequence.ResumeLayout(false);
        grpClick.ResumeLayout(false);
        grpRepeat.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numStepDelay).EndInit();
        ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
        ((System.ComponentModel.ISupportInitialize)numRepeatCount).EndInit();
        ResumeLayout(false);
    }

    private static void StyleFlatButton(Button button, Color backColor, Color foreColor)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.BackColor = backColor;
        button.ForeColor = foreColor;
        button.Cursor = Cursors.Hand;
    }

    #endregion
}
