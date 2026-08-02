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
        StepActionType.KeyPress => Strings.StepKeyPress(Key.ToString(), DelayMs),
        _ => Strings.StepClick(TrimTitle(Target!.Title), Target.RelativeX, Target.RelativeY, DelayMs)
    };

    private static string TrimTitle(string title) => title.Length > 18 ? title[..18] + "…" : title;
}
