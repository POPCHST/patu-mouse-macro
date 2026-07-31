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

    private Button btnHelp;

    private GroupBox grpPosition;
    private RadioButton radCurrentPos;
    private RadioButton radFixedPos;

    private GroupBox grpCapture;
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

    private GroupBox grpClickOptions;
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

    private Label lblStatus;
    private Label lblClickCount;
    private Button btnStart;
    private Button btnStop;
    private Label lblHotkeyInfo;

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnHelp = new Button();

        grpPosition = new GroupBox();
        radCurrentPos = new RadioButton();
        radFixedPos = new RadioButton();

        grpCapture = new GroupBox();
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

        grpClickOptions = new GroupBox();
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

        lblStatus = new Label();
        lblClickCount = new Label();
        btnStart = new Button();
        btnStop = new Button();
        lblHotkeyInfo = new Label();

        grpPosition.SuspendLayout();
        grpCapture.SuspendLayout();
        grpClickOptions.SuspendLayout();
        grpRepeat.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numStepDelay).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numRepeatCount).BeginInit();
        SuspendLayout();

        // btnHelp
        btnHelp.Text = "❓ วิธีใช้";
        btnHelp.Location = new Point(340, 10);
        btnHelp.Size = new Size(88, 26);

        // grpPosition
        grpPosition.Text = "ขั้นตอนที่ 1 — เลือกโหมดการคลิก";
        grpPosition.Location = new Point(12, 44);
        grpPosition.Size = new Size(416, 80);
        grpPosition.Controls.Add(radCurrentPos);
        grpPosition.Controls.Add(radFixedPos);

        // radCurrentPos
        radCurrentPos.Text = "คลิกตามตำแหน่งเมาส์ (ชี้ตรงไหน คลิกตรงนั้น)";
        radCurrentPos.Location = new Point(15, 25);
        radCurrentPos.Size = new Size(386, 20);
        radCurrentPos.Checked = true;

        // radFixedPos
        radFixedPos.Text = "คลิกตามลำดับจุดที่ตั้งไว้ (เพิ่มได้หลายจุด)";
        radFixedPos.Location = new Point(15, 50);
        radFixedPos.Size = new Size(386, 20);

        // grpCapture
        grpCapture.Text = "ขั้นตอนที่ 2 — ตั้งลำดับจุดคลิก (ใช้เมื่อเลือกคลิกตามลำดับจุด)";
        grpCapture.Location = new Point(12, 134);
        grpCapture.Size = new Size(416, 260);
        grpCapture.Controls.Add(btnCapture);
        grpCapture.Controls.Add(lblStepDelay);
        grpCapture.Controls.Add(numStepDelay);
        grpCapture.Controls.Add(lblKeyPress);
        grpCapture.Controls.Add(cmbKeyToPress);
        grpCapture.Controls.Add(btnAddKeyStep);
        grpCapture.Controls.Add(lstSteps);
        grpCapture.Controls.Add(btnRemoveStep);
        grpCapture.Controls.Add(btnClearSteps);
        grpCapture.Controls.Add(lblStepCount);

        // btnCapture
        btnCapture.Text = "📍 ชี้เมาส์ที่ปุ่มในเกม แล้วกดตรงนี้เพื่อเพิ่มจุด (F8)";
        btnCapture.Location = new Point(15, 25);
        btnCapture.Size = new Size(386, 34);
        btnCapture.Enabled = false;
        btnCapture.BackColor = Color.FromArgb(214, 232, 255);
        btnCapture.Font = new Font(Font, FontStyle.Bold);

        // lblStepDelay
        lblStepDelay.Text = "หน่วงเวลาหลังจุดนี้ (ms):";
        lblStepDelay.Location = new Point(15, 66);
        lblStepDelay.Size = new Size(155, 20);
        lblStepDelay.TextAlign = ContentAlignment.MiddleLeft;

        // numStepDelay
        numStepDelay.Location = new Point(175, 63);
        numStepDelay.Size = new Size(100, 23);
        numStepDelay.Minimum = 10;
        numStepDelay.Maximum = 600000;
        numStepDelay.Value = 1000;
        numStepDelay.ThousandsSeparator = true;

        // lblKeyPress
        lblKeyPress.Text = "หรือกดคีย์แทน:";
        lblKeyPress.Location = new Point(15, 98);
        lblKeyPress.Size = new Size(105, 20);
        lblKeyPress.TextAlign = ContentAlignment.MiddleLeft;

        // cmbKeyToPress
        cmbKeyToPress.Location = new Point(120, 95);
        cmbKeyToPress.Size = new Size(90, 23);
        cmbKeyToPress.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbKeyToPress.Items.AddRange(new object[] { "Enter", "F5", "F1", "F2", "F3", "F4", "F9", "F10", "F11", "F12", "Space", "Esc", "Tab" });
        cmbKeyToPress.SelectedIndex = 0;

        // btnAddKeyStep
        btnAddKeyStep.Text = "⌨ เพิ่มการกดคีย์นี้";
        btnAddKeyStep.Location = new Point(220, 93);
        btnAddKeyStep.Size = new Size(181, 27);

        // lstSteps
        lstSteps.Location = new Point(15, 128);
        lstSteps.Size = new Size(386, 82);
        lstSteps.IntegralHeight = false;

        // btnRemoveStep
        btnRemoveStep.Text = "ลบจุดที่เลือก";
        btnRemoveStep.Location = new Point(15, 218);
        btnRemoveStep.Size = new Size(120, 27);

        // btnClearSteps
        btnClearSteps.Text = "ล้างทั้งหมด";
        btnClearSteps.Location = new Point(143, 218);
        btnClearSteps.Size = new Size(100, 27);

        // lblStepCount
        lblStepCount.Text = "ทั้งหมด: 0 จุด";
        lblStepCount.Location = new Point(255, 223);
        lblStepCount.Size = new Size(146, 20);
        lblStepCount.ForeColor = Color.DimGray;
        lblStepCount.TextAlign = ContentAlignment.MiddleRight;

        // grpClickOptions
        grpClickOptions.Text = "ขั้นตอนที่ 3 — ตั้งค่าการคลิก";
        grpClickOptions.Location = new Point(12, 404);
        grpClickOptions.Size = new Size(416, 150);
        grpClickOptions.Controls.Add(lblButton);
        grpClickOptions.Controls.Add(cmbButton);
        grpClickOptions.Controls.Add(lblInterval);
        grpClickOptions.Controls.Add(numInterval);
        grpClickOptions.Controls.Add(lblIntervalHint);
        grpClickOptions.Controls.Add(chkJitter);

        // lblButton
        lblButton.Text = "ปุ่มเมาส์:";
        lblButton.Location = new Point(15, 28);
        lblButton.Size = new Size(80, 20);
        lblButton.TextAlign = ContentAlignment.MiddleLeft;

        // cmbButton
        cmbButton.Location = new Point(100, 25);
        cmbButton.Size = new Size(130, 23);
        cmbButton.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbButton.Items.AddRange(new object[] { "ซ้าย (Left)", "ขวา (Right)", "กลาง (Middle)" });
        cmbButton.SelectedIndex = 0;

        // lblInterval
        lblInterval.Text = "ทุกๆ (ms):";
        lblInterval.Location = new Point(15, 58);
        lblInterval.Size = new Size(80, 20);
        lblInterval.TextAlign = ContentAlignment.MiddleLeft;

        // numInterval
        numInterval.Location = new Point(100, 55);
        numInterval.Size = new Size(100, 23);
        numInterval.Minimum = 10;
        numInterval.Maximum = 600000;
        numInterval.Value = 1000;
        numInterval.ThousandsSeparator = true;

        // lblIntervalHint
        lblIntervalHint.Text = "* ใช้เฉพาะโหมด \"คลิกตามตำแหน่งเมาส์\" — โหมดคลิกตามลำดับจุดใช้ค่าหน่วงของแต่ละจุดแทน";
        lblIntervalHint.Location = new Point(15, 82);
        lblIntervalHint.Size = new Size(386, 32);
        lblIntervalHint.ForeColor = Color.Gray;

        // chkJitter
        chkJitter.Text = "สุ่มเวลาคลิกเล็กน้อย (กันรูปแบบเวลาเป๊ะเกินไป)";
        chkJitter.Location = new Point(15, 118);
        chkJitter.Size = new Size(386, 20);
        chkJitter.Checked = true;

        // grpRepeat
        grpRepeat.Text = "ขั้นตอนที่ 4 — การทำซ้ำ";
        grpRepeat.Location = new Point(12, 564);
        grpRepeat.Size = new Size(416, 72);
        grpRepeat.Controls.Add(radRepeatForever);
        grpRepeat.Controls.Add(radRepeatCount);
        grpRepeat.Controls.Add(numRepeatCount);
        grpRepeat.Controls.Add(lblTimes);

        // radRepeatForever
        radRepeatForever.Text = "ทำซ้ำไปเรื่อยๆ จนกว่าจะกด Stop";
        radRepeatForever.Location = new Point(15, 22);
        radRepeatForever.Size = new Size(250, 20);
        radRepeatForever.Checked = true;

        // radRepeatCount
        radRepeatCount.Text = "ทำซ้ำจำนวน (รอบ):";
        radRepeatCount.Location = new Point(15, 45);
        radRepeatCount.Size = new Size(140, 20);

        // numRepeatCount
        numRepeatCount.Location = new Point(160, 43);
        numRepeatCount.Size = new Size(80, 23);
        numRepeatCount.Minimum = 1;
        numRepeatCount.Maximum = 1000000;
        numRepeatCount.Value = 10;
        numRepeatCount.Enabled = false;

        // lblTimes
        lblTimes.Text = "รอบ";
        lblTimes.Location = new Point(245, 45);
        lblTimes.Size = new Size(40, 20);
        lblTimes.TextAlign = ContentAlignment.MiddleLeft;

        // lblStatus
        lblStatus.Text = "สถานะ: หยุด";
        lblStatus.Location = new Point(15, 646);
        lblStatus.Size = new Size(400, 20);
        lblStatus.Font = new Font(Font, FontStyle.Bold);

        // lblClickCount
        lblClickCount.Text = "จำนวนการทำงาน: 0";
        lblClickCount.Location = new Point(15, 668);
        lblClickCount.Size = new Size(400, 20);

        // btnStart
        btnStart.Text = "▶ Start (F6)";
        btnStart.Location = new Point(15, 698);
        btnStart.Size = new Size(196, 44);
        btnStart.BackColor = Color.FromArgb(198, 239, 206);
        btnStart.Font = new Font(Font.FontFamily, 11f, FontStyle.Bold);

        // btnStop
        btnStop.Text = "■ Stop (F7)";
        btnStop.Location = new Point(221, 698);
        btnStop.Size = new Size(196, 44);
        btnStop.Enabled = false;
        btnStop.BackColor = Color.FromArgb(255, 199, 206);
        btnStop.Font = new Font(Font.FontFamily, 11f, FontStyle.Bold);

        // lblHotkeyInfo
        lblHotkeyInfo.Text = "Hotkey (ใช้ได้แม้อยู่ในเกม): F6 = Start, F7 = Stop, F8 = เพิ่มจุด";
        lblHotkeyInfo.Location = new Point(15, 752);
        lblHotkeyInfo.Size = new Size(400, 20);
        lblHotkeyInfo.ForeColor = Color.Gray;

        // Form1
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Tahoma", 9f);
        ClientSize = new Size(440, 785);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "patu.v1-mouse-macro";
        Controls.Add(btnHelp);
        Controls.Add(grpPosition);
        Controls.Add(grpCapture);
        Controls.Add(grpClickOptions);
        Controls.Add(grpRepeat);
        Controls.Add(lblStatus);
        Controls.Add(lblClickCount);
        Controls.Add(btnStart);
        Controls.Add(btnStop);
        Controls.Add(lblHotkeyInfo);

        grpPosition.ResumeLayout(false);
        grpCapture.ResumeLayout(false);
        grpClickOptions.ResumeLayout(false);
        grpRepeat.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numStepDelay).EndInit();
        ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
        ((System.ComponentModel.ISupportInitialize)numRepeatCount).EndInit();
        ResumeLayout(false);
    }

    #endregion
}
