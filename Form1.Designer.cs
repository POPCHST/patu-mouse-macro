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
    private Label lblTargetInfo;
    private Label lblAdvancedHint;
    private Label lblX;
    private NumericUpDown numX;
    private Label lblY;
    private NumericUpDown numY;

    private GroupBox grpClickOptions;
    private Label lblButton;
    private ComboBox cmbButton;
    private Label lblInterval;
    private NumericUpDown numInterval;
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
        lblTargetInfo = new Label();
        lblAdvancedHint = new Label();
        lblX = new Label();
        numX = new NumericUpDown();
        lblY = new Label();
        numY = new NumericUpDown();

        grpClickOptions = new GroupBox();
        lblButton = new Label();
        cmbButton = new ComboBox();
        lblInterval = new Label();
        numInterval = new NumericUpDown();
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
        ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
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
        radFixedPos.Text = "คลิกตำแหน่งเดิมซ้ำๆ (แนะนำสำหรับปุ่ม Start ในเกม)";
        radFixedPos.Location = new Point(15, 50);
        radFixedPos.Size = new Size(386, 20);

        // grpCapture
        grpCapture.Text = "ขั้นตอนที่ 2 — ตั้งตำแหน่งคลิก (ใช้เมื่อเลือกคลิกตำแหน่งเดิม)";
        grpCapture.Location = new Point(12, 134);
        grpCapture.Size = new Size(416, 150);
        grpCapture.Controls.Add(btnCapture);
        grpCapture.Controls.Add(lblTargetInfo);
        grpCapture.Controls.Add(lblAdvancedHint);
        grpCapture.Controls.Add(lblX);
        grpCapture.Controls.Add(numX);
        grpCapture.Controls.Add(lblY);
        grpCapture.Controls.Add(numY);

        // btnCapture
        btnCapture.Text = "📍 วางเมาส์บนปุ่มในเกม แล้วกดตรงนี้ (หรือกด F8)";
        btnCapture.Location = new Point(15, 25);
        btnCapture.Size = new Size(386, 34);
        btnCapture.Enabled = false;
        btnCapture.BackColor = Color.FromArgb(214, 232, 255);
        btnCapture.Font = new Font(Font, FontStyle.Bold);

        // lblTargetInfo
        lblTargetInfo.Text = "เป้าหมาย: ยังไม่ได้ตั้งตำแหน่ง";
        lblTargetInfo.Location = new Point(15, 65);
        lblTargetInfo.Size = new Size(386, 36);
        lblTargetInfo.ForeColor = Color.DimGray;

        // lblAdvancedHint
        lblAdvancedHint.Text = "ปรับละเอียด (ถ้าจำเป็น):";
        lblAdvancedHint.Location = new Point(15, 105);
        lblAdvancedHint.Size = new Size(150, 18);
        lblAdvancedHint.ForeColor = Color.Gray;

        // lblX
        lblX.Text = "X (%):";
        lblX.Location = new Point(15, 125);
        lblX.Size = new Size(45, 20);
        lblX.TextAlign = ContentAlignment.MiddleLeft;
        lblX.ForeColor = Color.Gray;

        // numX
        numX.Location = new Point(60, 123);
        numX.Size = new Size(70, 23);
        numX.Minimum = 0;
        numX.Maximum = 100;
        numX.DecimalPlaces = 1;
        numX.Increment = 0.1m;
        numX.Enabled = false;

        // lblY
        lblY.Text = "Y (%):";
        lblY.Location = new Point(140, 125);
        lblY.Size = new Size(45, 20);
        lblY.TextAlign = ContentAlignment.MiddleLeft;
        lblY.ForeColor = Color.Gray;

        // numY
        numY.Location = new Point(185, 123);
        numY.Size = new Size(70, 23);
        numY.Minimum = 0;
        numY.Maximum = 100;
        numY.DecimalPlaces = 1;
        numY.Increment = 0.1m;
        numY.Enabled = false;

        // grpClickOptions
        grpClickOptions.Text = "ขั้นตอนที่ 3 — ตั้งค่าการคลิก";
        grpClickOptions.Location = new Point(12, 294);
        grpClickOptions.Size = new Size(416, 115);
        grpClickOptions.Controls.Add(lblButton);
        grpClickOptions.Controls.Add(cmbButton);
        grpClickOptions.Controls.Add(lblInterval);
        grpClickOptions.Controls.Add(numInterval);
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

        // chkJitter
        chkJitter.Text = "สุ่มเวลาคลิกเล็กน้อย (กันรูปแบบเวลาเป๊ะเกินไป)";
        chkJitter.Location = new Point(15, 85);
        chkJitter.Size = new Size(386, 20);
        chkJitter.Checked = true;

        // grpRepeat
        grpRepeat.Text = "ขั้นตอนที่ 4 — การทำซ้ำ";
        grpRepeat.Location = new Point(12, 419);
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
        radRepeatCount.Text = "ทำซ้ำจำนวน:";
        radRepeatCount.Location = new Point(15, 45);
        radRepeatCount.Size = new Size(110, 20);

        // numRepeatCount
        numRepeatCount.Location = new Point(130, 43);
        numRepeatCount.Size = new Size(80, 23);
        numRepeatCount.Minimum = 1;
        numRepeatCount.Maximum = 1000000;
        numRepeatCount.Value = 10;
        numRepeatCount.Enabled = false;

        // lblTimes
        lblTimes.Text = "ครั้ง";
        lblTimes.Location = new Point(215, 45);
        lblTimes.Size = new Size(40, 20);
        lblTimes.TextAlign = ContentAlignment.MiddleLeft;

        // lblStatus
        lblStatus.Text = "สถานะ: หยุด";
        lblStatus.Location = new Point(15, 501);
        lblStatus.Size = new Size(400, 20);
        lblStatus.Font = new Font(Font, FontStyle.Bold);

        // lblClickCount
        lblClickCount.Text = "จำนวนคลิก: 0";
        lblClickCount.Location = new Point(15, 523);
        lblClickCount.Size = new Size(400, 20);

        // btnStart
        btnStart.Text = "▶ Start (F6)";
        btnStart.Location = new Point(15, 553);
        btnStart.Size = new Size(196, 44);
        btnStart.BackColor = Color.FromArgb(198, 239, 206);
        btnStart.Font = new Font(Font.FontFamily, 11f, FontStyle.Bold);

        // btnStop
        btnStop.Text = "■ Stop (F7)";
        btnStop.Location = new Point(221, 553);
        btnStop.Size = new Size(196, 44);
        btnStop.Enabled = false;
        btnStop.BackColor = Color.FromArgb(255, 199, 206);
        btnStop.Font = new Font(Font.FontFamily, 11f, FontStyle.Bold);

        // lblHotkeyInfo
        lblHotkeyInfo.Text = "Hotkey (ใช้ได้แม้อยู่ในเกม): F6 = Start, F7 = Stop, F8 = จับตำแหน่ง";
        lblHotkeyInfo.Location = new Point(15, 607);
        lblHotkeyInfo.Size = new Size(400, 20);
        lblHotkeyInfo.ForeColor = Color.Gray;

        // Form1
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Tahoma", 9f);
        ClientSize = new Size(440, 640);
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
        ((System.ComponentModel.ISupportInitialize)numX).EndInit();
        ((System.ComponentModel.ISupportInitialize)numY).EndInit();
        ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
        ((System.ComponentModel.ISupportInitialize)numRepeatCount).EndInit();
        ResumeLayout(false);
    }

    #endregion
}
