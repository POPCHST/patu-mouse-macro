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
        "• คลิกตามลำดับจุดที่ตั้งไว้: เพิ่มได้หลายจุด โปรแกรมจะคลิกวนตามลำดับที่เพิ่มไว้",
        "",
        "ขั้นตอนที่ 2 — ตั้งลำดับจุดคลิก (เมื่อเลือก \"คลิกตามลำดับจุดที่ตั้งไว้\")",
        "1. ตั้ง \"หน่วงเวลาหลังจุดนี้\" ไว้ก่อน (เวลาที่จะรอ หลังคลิกจุดนี้ ก่อนไปคลิกจุดถัดไป)",
        "2. เอาเมาส์ไปชี้ตรงปุ่มที่ต้องการในเกม แล้วกดปุ่ม \"เพิ่มจุด\" หรือกด F8",
        "3. ทำซ้ำข้อ 1-2 เพื่อเพิ่มจุดคลิกถัดไปในลำดับ (จุดที่ 2, 3, ...)",
        "4. รายการจุดที่เพิ่มไว้จะแสดงในลิสต์ กดเลือกแล้วกด \"ลบจุดที่เลือก\" ได้ถ้าต้องการแก้ไข",
        "5. ตอนรัน โปรแกรมจะคลิกทีละจุดตามลำดับ วนกลับไปจุดแรกเมื่อคลิกครบทุกจุดแล้ว",
        "",
        "ขั้นตอนที่ 3 — ตั้งค่าการคลิก",
        "• เลือกปุ่มเมาส์ที่จะให้คลิก (ซ้าย/ขวา/กลาง) — ใช้ปุ่มเดียวกันกับทุกจุด",
        "• \"ทุกๆ (ms)\" ใช้เฉพาะโหมดคลิกตามตำแหน่งเมาส์เท่านั้น (โหมดลำดับจุดใช้ค่าหน่วงของแต่ละจุดแทน)",
        "• ติ๊ก \"สุ่มเวลาคลิกเล็กน้อย\" ไว้ เพื่อให้จังหวะคลิกดูเป็นธรรมชาติ ไม่ตายตัวเป๊ะเกินไป",
        "",
        "ขั้นตอนที่ 4 — การทำซ้ำ",
        "• เลือกทำซ้ำไปเรื่อยๆ จนกว่าจะกด Stop หรือกำหนดจำนวนรอบที่ต้องการ",
        "• 1 \"รอบ\" คือการคลิกครบทุกจุดในลำดับ 1 รอบ (ถ้ามีจุดเดียว 1 รอบ = 1 คลิก เหมือนเดิม)",
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
