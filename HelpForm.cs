namespace MouseMacro;

public sealed class HelpForm : Form
{
    public HelpForm()
    {
        Text = Strings.Current switch
        {
            AppLanguage.Thai => "วิธีใช้งาน patu.v1-mouse-macro",
            AppLanguage.Chinese => "patu.v1-mouse-macro 使用说明",
            _ => "How to use patu.v1-mouse-macro"
        };
        ClientSize = new Size(420, 340);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath) ?? SystemIcons.Application;

        var textBox = new RichTextBox
        {
            Location = new Point(12, 12),
            Size = new Size(396, 280),
            ReadOnly = true,
            BorderStyle = BorderStyle.None,
            BackColor = SystemColors.Control,
            Font = new Font(Font.FontFamily, 10.5f),
            Text = BuildHelpText()
        };

        var btnClose = new Button
        {
            Text = Strings.Current switch
            {
                AppLanguage.Thai => "ปิด",
                AppLanguage.Chinese => "关闭",
                _ => "Close"
            },
            Location = new Point(320, 300),
            Size = new Size(88, 28),
            DialogResult = DialogResult.OK
        };

        Controls.Add(textBox);
        Controls.Add(btnClose);
        AcceptButton = btnClose;
    }

    private static string BuildHelpText() => string.Join(Environment.NewLine, Strings.Current switch
    {
        AppLanguage.Thai => ThaiLines,
        AppLanguage.Chinese => ChineseLines,
        _ => EnglishLines
    });

    private static readonly string[] ThaiLines =
    {
        "🖱️ เริ่มใช้งานเร็ว",
        "",
        "1️⃣ แท็บ \"การคลิก\" — เลือกโหมด",
        "   • ตามเมาส์: ชี้ตรงไหน คลิกตรงนั้น",
        "   • ตามลำดับจุด: ชี้ปุ่มในเกม กด F8 เพิ่มจุด (เพิ่มได้เรื่อยๆ)",
        "",
        "2️⃣ แท็บ \"ตั้งค่า\" — ปรับปุ่มเมาส์ ความถี่ จำนวนรอบ",
        "",
        "3️⃣ กด ▶ Start (F6) เริ่ม / ■ Stop (F7) หยุด",
        "   ใช้ได้แม้กำลังอยู่ในเกม",
        "",
        "💡 แท็บ \"รอผู้เล่น\": ให้รอเพื่อนเข้าห้องก่อนเริ่ม (ไม่บังคับ)",
        "",
        "⚠️ เช็คกฎเกมก่อนใช้ บางเกมอาจห้ามใช้โปรแกรมอัตโนมัติ",
    };

    private static readonly string[] EnglishLines =
    {
        "🖱️ Quick Start",
        "",
        "1️⃣ \"Click\" tab — choose a mode",
        "   • By mouse: clicks wherever you point.",
        "   • By sequence: point at a game button, press F8 to add (repeat as needed).",
        "",
        "2️⃣ \"Settings\" tab — set mouse button, timing, and rounds",
        "",
        "3️⃣ Press ▶ Start (F6) / ■ Stop (F7)",
        "   Works even while the game has focus.",
        "",
        "💡 \"Wait\" tab: wait for a friend to join before starting (optional)",
        "",
        "⚠️ Check the game's rules first — some ban automation tools.",
    };

    private static readonly string[] ChineseLines =
    {
        "🖱️ 快速开始",
        "",
        "1️⃣ “点击”标签页 — 选择模式",
        "   • 跟随鼠标:指向哪里就点哪里。",
        "   • 按顺序点击:指向游戏按钮,按 F8 添加(可多次添加)。",
        "",
        "2️⃣ “设置”标签页 — 设置鼠标按钮、间隔、重复轮数",
        "",
        "3️⃣ 按 ▶ Start (F6) 开始 / ■ Stop (F7) 停止",
        "   即使在游戏窗口中也能使用。",
        "",
        "💡 “等待玩家”标签页:等朋友加入房间后再开始(可选)",
        "",
        "⚠️ 使用前请确认游戏规则,部分游戏禁止自动化工具。",
    };
}
