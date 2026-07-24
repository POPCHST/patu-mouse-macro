namespace MouseMacro;

public sealed class HelpForm : Form
{
    public HelpForm()
    {
        Text = "วิธีใช้งาน patu.v1-mouse-macro";
        ClientSize = new Size(460, 480);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath) ?? SystemIcons.Application;

        var textBox = new RichTextBox
        {
            Location = new Point(12, 12),
            Size = new Size(436, 420),
            ReadOnly = true,
            BorderStyle = BorderStyle.None,
            BackColor = SystemColors.Control,
            Font = new Font(Font.FontFamily, 10f),
            Text = BuildHelpText()
        };

        var btnClose = new Button
        {
            Text = "ปิด",
            Location = new Point(360, 440),
            Size = new Size(88, 28),
            DialogResult = DialogResult.OK
        };

        Controls.Add(textBox);
        Controls.Add(btnClose);
        AcceptButton = btnClose;
    }

    private static string BuildHelpText() => string.Join(Environment.NewLine, new[]
    {
        "ขั้นตอนที่ 1 — เลือกโหมดการคลิก",
        "• คลิกตามตำแหน่งเมาส์: เอาเมาส์ไปวางไว้ตรงไหน โปรแกรมจะคลิกตรงนั้น",
        "• คลิกตำแหน่งเดิมซ้ำๆ: ใช้แบบนี้สำหรับกดปุ่ม Start ในเกมซ้ำๆ",
        "",
        "ขั้นตอนที่ 2 — ตั้งตำแหน่งคลิก (เมื่อเลือก \"คลิกตำแหน่งเดิมซ้ำๆ\")",
        "1. เอาเมาส์ไปชี้ตรงปุ่มที่ต้องการในเกม (เช่นปุ่ม Start)",
        "2. กดปุ่ม \"จับตำแหน่ง\" ในโปรแกรม หรือกด F8",
        "3. โปรแกรมจะจดจำตำแหน่งนั้นไว้ ให้ดูข้อความ \"เป้าหมาย\" เพื่อยืนยัน",
        "   (ช่อง X%/Y% ด้านล่างมีไว้ปรับละเอียดเผื่อจุดคลิกเพี้ยนนิดหน่อย ไม่จำเป็นต้องแตะถ้าจับตำแหน่งแม่นแล้ว)",
        "",
        "ขั้นตอนที่ 3 — ตั้งค่าการคลิก",
        "• เลือกปุ่มเมาส์ที่จะให้คลิก (ซ้าย/ขวา/กลาง)",
        "• ตั้งความถี่การคลิก (ทุกกี่มิลลิวินาที)",
        "• ติ๊ก \"สุ่มเวลาคลิกเล็กน้อย\" ไว้ เพื่อให้จังหวะคลิกดูเป็นธรรมชาติ ไม่ตายตัวเป๊ะเกินไป",
        "",
        "ขั้นตอนที่ 4 — การทำซ้ำ",
        "• เลือกทำซ้ำไปเรื่อยๆ จนกว่าจะกด Stop หรือกำหนดจำนวนครั้งที่ต้องการ",
        "",
        "เริ่ม/หยุดการทำงาน",
        "• กด Start หรือกด F6 เพื่อเริ่มคลิกอัตโนมัติ",
        "• กด Stop หรือกด F7 เพื่อหยุด",
        "• ปุ่ม F6/F7/F8 ใช้ได้ตลอดแม้กำลังโฟกัสอยู่ในหน้าต่างเกม ไม่ต้องสลับกลับมาที่โปรแกรมนี้",
        "",
        "ข้อควรระวัง",
        "• เกมบางเกมอาจมีข้อห้ามเรื่องการใช้โปรแกรมอัตโนมัติ/macro ควรตรวจสอบกฎของเกมก่อนใช้งาน",
        "• ถ้าเกมรันแบบ Administrator ต้องเปิดโปรแกรมนี้แบบ Administrator ด้วย ไม่งั้นคลิกจะไม่ทำงานในเกม",
    });
}
