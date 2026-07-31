namespace MouseMacro;

internal sealed class MacroStep
{
    public required MacroTarget Target { get; init; }
    public int DelayMs { get; set; }

    public override string ToString()
    {
        var title = Target.Title.Length > 18 ? Target.Title[..18] + "…" : Target.Title;
        return $"\"{title}\" ({Target.RelativeX * 100:0.0}%, {Target.RelativeY * 100:0.0}%) — หน่วง {DelayMs}ms";
    }
}
