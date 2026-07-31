namespace MouseMacro;

internal enum StepActionType
{
    Click,
    KeyPress
}

internal sealed class MacroStep
{
    public required StepActionType ActionType { get; init; }
    public MacroTarget? Target { get; init; }
    public Keys Key { get; init; }
    public int DelayMs { get; set; }

    public override string ToString() => ActionType switch
    {
        StepActionType.KeyPress => $"⌨ กดคีย์ {Key} — หน่วง {DelayMs}ms",
        _ => $"📍 \"{TrimTitle(Target!.Title)}\" ({Target.RelativeX * 100:0.0}%, {Target.RelativeY * 100:0.0}%) — หน่วง {DelayMs}ms"
    };

    private static string TrimTitle(string title) => title.Length > 18 ? title[..18] + "…" : title;
}
