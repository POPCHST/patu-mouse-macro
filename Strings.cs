namespace MouseMacro;

internal static class Strings
{
    public static AppLanguage Current { get; set; } = AppLanguage.Thai;

    public static string HelpButton => Current switch
    {
        AppLanguage.Thai => "❓ วิธีใช้",
        AppLanguage.Chinese => "❓ 帮助",
        _ => "❓ Help"
    };

    public static string TabClick => Current switch
    {
        AppLanguage.Thai => "🖱️ การคลิก",
        AppLanguage.Chinese => "🖱️ 点击",
        _ => "🖱️ Click"
    };

    public static string TabSettings => Current switch
    {
        AppLanguage.Thai => "⚙️ ตั้งค่า",
        AppLanguage.Chinese => "⚙️ 设置",
        _ => "⚙️ Settings"
    };

    public static string TabPresence => Current switch
    {
        AppLanguage.Thai => "👁️ รอผู้เล่น",
        AppLanguage.Chinese => "👁️ 等待玩家",
        _ => "👁️ Wait"
    };

    public static string ModeGroupTitle => Current switch
    {
        AppLanguage.Thai => "โหมดการคลิก",
        AppLanguage.Chinese => "点击模式",
        _ => "Click mode"
    };

    public static string ModeCurrentPos => Current switch
    {
        AppLanguage.Thai => "คลิกตามตำแหน่งเมาส์ (ชี้ตรงไหน คลิกตรงนั้น)",
        AppLanguage.Chinese => "跟随鼠标位置点击(指向哪里就点哪里)",
        _ => "Click at mouse position"
    };

    public static string ModeFixedPos => Current switch
    {
        AppLanguage.Thai => "คลิกตามลำดับจุดที่ตั้งไว้ (เพิ่มได้หลายจุด)",
        AppLanguage.Chinese => "按设定的顺序点击(可添加多个点)",
        _ => "Click through a saved sequence"
    };

    public static string SequenceGroupTitle => Current switch
    {
        AppLanguage.Thai => "ลำดับจุดคลิก (ใช้เมื่อเลือกคลิกตามลำดับจุด)",
        AppLanguage.Chinese => "点击顺序(选择顺序模式时使用)",
        _ => "Click sequence"
    };

    public static string CaptureButton => Current switch
    {
        AppLanguage.Thai => "📍 ชี้เมาส์ที่ปุ่มในเกม แล้วกดตรงนี้เพื่อเพิ่มจุด (F8)",
        AppLanguage.Chinese => "📍 将鼠标指向游戏中的按钮,然后点击这里添加一个点 (F8)",
        _ => "📍 Point at a game button, click to add (F8)"
    };

    public static string StepDelayLabel => Current switch
    {
        AppLanguage.Thai => "หน่วงเวลาหลังจุดนี้ (ms):",
        AppLanguage.Chinese => "延迟(毫秒):",
        _ => "Delay (ms):"
    };

    public static string KeyPressLabel => Current switch
    {
        AppLanguage.Thai => "หรือกดคีย์แทน:",
        AppLanguage.Chinese => "或改为按键:",
        _ => "Or press key:"
    };

    public static string AddKeyStepButton => Current switch
    {
        AppLanguage.Thai => "⌨ เพิ่มการกดคีย์นี้",
        AppLanguage.Chinese => "⌨ 添加此按键",
        _ => "⌨ Add key"
    };

    public static string RemoveStepButton => Current switch
    {
        AppLanguage.Thai => "ลบจุดที่เลือก",
        AppLanguage.Chinese => "删除所选项",
        _ => "Remove selected"
    };

    public static string ClearStepsButton => Current switch
    {
        AppLanguage.Thai => "ล้างทั้งหมด",
        AppLanguage.Chinese => "清除全部",
        _ => "Clear all"
    };

    public static string TotalPoints(int count) => Current switch
    {
        AppLanguage.Thai => $"ทั้งหมด: {count} จุด",
        AppLanguage.Chinese => $"共 {count} 个点",
        _ => $"Total: {count} point(s)"
    };

    public static string ClickSettingsGroupTitle => Current switch
    {
        AppLanguage.Thai => "ตั้งค่าการคลิก",
        AppLanguage.Chinese => "点击设置",
        _ => "Click settings"
    };

    public static string MouseButtonLabel => Current switch
    {
        AppLanguage.Thai => "ปุ่มเมาส์:",
        AppLanguage.Chinese => "鼠标按钮:",
        _ => "Mouse button:"
    };

    public static string[] MouseButtonItems => Current switch
    {
        AppLanguage.Thai => new[] { "ซ้าย (Left)", "ขวา (Right)", "กลาง (Middle)" },
        AppLanguage.Chinese => new[] { "左键", "右键", "中键" },
        _ => new[] { "Left", "Right", "Middle" }
    };

    public static string IntervalLabel => Current switch
    {
        AppLanguage.Thai => "ทุกๆ (ms):",
        AppLanguage.Chinese => "间隔 (毫秒):",
        _ => "Every (ms):"
    };

    public static string IntervalHint => Current switch
    {
        AppLanguage.Thai => "* ใช้เฉพาะโหมด \"คลิกตามตำแหน่งเมาส์\" — โหมดคลิกตามลำดับจุดใช้ค่าหน่วงของแต่ละจุดแทน",
        AppLanguage.Chinese => "* 仅在“跟随鼠标位置点击”模式下使用 — 顺序模式则使用每个点各自的延迟",
        _ => "* Only used in mouse-position mode (sequence mode uses each point's own delay)"
    };

    public static string JitterCheckbox => Current switch
    {
        AppLanguage.Thai => "สุ่มเวลาคลิกเล็กน้อย (กันรูปแบบเวลาเป๊ะเกินไป)",
        AppLanguage.Chinese => "添加轻微随机时间抖动(避免时间间隔过于规律)",
        _ => "Randomize timing slightly (less robotic)"
    };

    public static string RepeatGroupTitle => Current switch
    {
        AppLanguage.Thai => "การทำซ้ำ",
        AppLanguage.Chinese => "重复",
        _ => "Repeat"
    };

    public static string RepeatForever => Current switch
    {
        AppLanguage.Thai => "ทำซ้ำไปเรื่อยๆ จนกว่าจะกด Stop",
        AppLanguage.Chinese => "持续重复直到按下停止",
        _ => "Repeat until Stop is pressed"
    };

    public static string RepeatCount => Current switch
    {
        AppLanguage.Thai => "ทำซ้ำจำนวน (รอบ):",
        AppLanguage.Chinese => "重复次数(轮):",
        _ => "Repeat count:"
    };

    public static string RoundsLabel => Current switch
    {
        AppLanguage.Thai => "รอบ",
        AppLanguage.Chinese => "轮",
        _ => "rounds"
    };

    public static string PresenceGroupTitle => Current switch
    {
        AppLanguage.Thai => "รอผู้เล่นก่อนเริ่ม (ไม่บังคับ)",
        AppLanguage.Chinese => "开始前等待玩家加入(可选)",
        _ => "Wait for a player (optional)"
    };

    public static string CapturePresenceButton => Current switch
    {
        AppLanguage.Thai => "👁 ตั้งจุดเช็คผู้เล่น (กดตอนห้องว่าง ไม่มีใครอยู่)",
        AppLanguage.Chinese => "👁 设置玩家检测点(在房间空无一人时点击)",
        _ => "👁 Set check point (room empty)"
    };

    public static string PresenceNotSet => Current switch
    {
        AppLanguage.Thai => "จุดเช็คผู้เล่น: ยังไม่ได้ตั้ง",
        AppLanguage.Chinese => "玩家检测点:尚未设置",
        _ => "Check point: not set"
    };

    public static string PresenceSet(string title) => Current switch
    {
        AppLanguage.Thai => $"จุดเช็คผู้เล่น: ตั้งแล้ว ที่ \"{title}\"",
        AppLanguage.Chinese => $"玩家检测点:已设置于 \"{title}\"",
        _ => $"Check point set: \"{title}\""
    };

    public static string WaitForPlayerCheckbox => Current switch
    {
        AppLanguage.Thai => "รอจนกว่าจะมีผู้เล่นเข้าห้อง ก่อนเริ่มคลิกอัตโนมัติ",
        AppLanguage.Chinese => "等待玩家加入房间后再开始自动点击",
        _ => "Wait for a player before starting"
    };

    public static string StatusIdle => Current switch
    {
        AppLanguage.Thai => "สถานะ: หยุด",
        AppLanguage.Chinese => "状态:已停止",
        _ => "Status: stopped"
    };

    public static string StatusStopped => Current switch
    {
        AppLanguage.Thai => "สถานะ: หยุดแล้ว",
        AppLanguage.Chinese => "状态:已停止",
        _ => "Status: stopped"
    };

    public static string StatusRunning => Current switch
    {
        AppLanguage.Thai => "สถานะ: กำลังทำงาน...",
        AppLanguage.Chinese => "状态:运行中...",
        _ => "Status: running..."
    };

    public static string StatusWaiting => Current switch
    {
        AppLanguage.Thai => "⏳ กำลังรอผู้เล่นเข้าห้อง...",
        AppLanguage.Chinese => "⏳ 正在等待玩家加入...",
        _ => "⏳ Waiting for a player to join..."
    };

    public static string StatusError => Current switch
    {
        AppLanguage.Thai => "⚠ หยุดทำงาน: ไม่พบหน้าต่างเกมที่จับตำแหน่งไว้ (ปิดไปแล้ว?) — กด F8 จับตำแหน่งใหม่",
        AppLanguage.Chinese => "⚠ 已停止:找不到已记录的游戏窗口(是否已关闭?)— 请按 F8 重新设置",
        _ => "⚠ Stopped: game window not found — press F8 again"
    };

    public static string ActionsDone(int count) => Current switch
    {
        AppLanguage.Thai => $"จำนวนการทำงาน: {count}",
        AppLanguage.Chinese => $"已执行次数: {count}",
        _ => $"Actions done: {count}"
    };

    public static string StartButton => "▶ Start (F6)";
    public static string StopButton => "■ Stop (F7)";

    public static string HotkeyInfo => Current switch
    {
        AppLanguage.Thai => "Hotkey (ใช้ได้แม้อยู่ในเกม): F6 = Start, F7 = Stop, F8 = เพิ่มจุด",
        AppLanguage.Chinese => "快捷键(游戏中也可用): F6 开始, F7 停止, F8 添加",
        _ => "Hotkeys (work in-game too): F6 Start, F7 Stop, F8 Add"
    };

    public static string CaptureFailed => Current switch
    {
        AppLanguage.Thai => "จับตำแหน่งไม่สำเร็จ ลองใหม่",
        AppLanguage.Chinese => "定位失败,请重试",
        _ => "Capture failed"
    };

    public static string NeedStepsFirst => Current switch
    {
        AppLanguage.Thai => "กรุณาเพิ่มจุดก่อน (F8)",
        AppLanguage.Chinese => "请先添加点 (F8)",
        _ => "Add a point (F8)"
    };

    public static string NeedPresencePointFirst => Current switch
    {
        AppLanguage.Thai => "กรุณาตั้งจุดเช็คผู้เล่นก่อน (ปุ่ม 👁)",
        AppLanguage.Chinese => "请先设置玩家检测点(👁 按钮)",
        _ => "Please set a check point first (👁)"
    };

    public static string UntitledWindow => Current switch
    {
        AppLanguage.Thai => "(ไม่มีชื่อหน้าต่าง)",
        AppLanguage.Chinese => "(无标题窗口)",
        _ => "(untitled window)"
    };

    public static string StepClick(string title, double relX, double relY, int delayMs) => Current switch
    {
        AppLanguage.Thai => $"📍 \"{title}\" ({relX * 100:0.0}%, {relY * 100:0.0}%) — หน่วง {delayMs}ms",
        AppLanguage.Chinese => $"📍 \"{title}\" ({relX * 100:0.0}%, {relY * 100:0.0}%) — 延迟 {delayMs}ms",
        _ => $"📍 \"{title}\" ({relX * 100:0.0}%, {relY * 100:0.0}%) — delay {delayMs}ms"
    };

    public static string StepKeyPress(string key, int delayMs) => Current switch
    {
        AppLanguage.Thai => $"⌨ กดคีย์ {key} — หน่วง {delayMs}ms",
        AppLanguage.Chinese => $"⌨ 按键 {key} — 延迟 {delayMs}ms",
        _ => $"⌨ Press {key} — delay {delayMs}ms"
    };
}
