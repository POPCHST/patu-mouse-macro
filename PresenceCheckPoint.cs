namespace MouseMacro;

internal sealed class PresenceCheckPoint
{
    private const int ColorDifferenceThreshold = 40;

    private readonly MacroTarget _target;
    private readonly Color _baselineColor;

    public PresenceCheckPoint(MacroTarget target, Color baselineColor)
    {
        _target = target;
        _baselineColor = baselineColor;
    }

    public string TargetTitle => _target.Title;

    public bool HasPlayerJoined()
    {
        if (!_target.TryResolveScreenPosition(out var position))
        {
            return false;
        }

        var current = PixelSampler.GetPixelColor(position);
        var diff = Math.Abs(current.R - _baselineColor.R)
                 + Math.Abs(current.G - _baselineColor.G)
                 + Math.Abs(current.B - _baselineColor.B);

        return diff > ColorDifferenceThreshold;
    }
}
