namespace MouseMacro;

/// <summary>
/// Remembers a click point as a fraction (0..1) of a target window's client area
/// instead of a raw screen pixel, so it keeps working if the window moves, resizes,
/// or the macro runs on a machine with a different screen resolution.
/// </summary>
internal sealed class MacroTarget
{
    public IntPtr Handle { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public double RelativeX { get; private set; }
    public double RelativeY { get; private set; }

    public bool IsCaptured => Handle != IntPtr.Zero;

    public static MacroTarget? CaptureAt(Point screenPosition)
    {
        var point = new NativeMethods.POINT { X = screenPosition.X, Y = screenPosition.Y };
        var hwnd = NativeMethods.WindowFromPoint(point);
        if (hwnd == IntPtr.Zero)
        {
            return null;
        }

        hwnd = NativeMethods.GetAncestor(hwnd, NativeMethods.GA_ROOT);

        if (!TryGetClientOrigin(hwnd, out var origin, out var width, out var height))
        {
            return null;
        }

        var sb = new System.Text.StringBuilder(256);
        NativeMethods.GetWindowText(hwnd, sb, sb.Capacity);

        return new MacroTarget
        {
            Handle = hwnd,
            Title = sb.Length > 0 ? sb.ToString() : Strings.UntitledWindow,
            RelativeX = (double)(screenPosition.X - origin.X) / width,
            RelativeY = (double)(screenPosition.Y - origin.Y) / height
        };
    }

    public void SetRelative(double relativeX, double relativeY)
    {
        RelativeX = relativeX;
        RelativeY = relativeY;
    }

    public void CopyHandleFrom(MacroTarget other)
    {
        Handle = other.Handle;
        Title = other.Title;
    }

    public bool TryResolveScreenPosition(out Point position)
    {
        position = default;

        if (!IsCaptured || !NativeMethods.IsWindow(Handle))
        {
            return false;
        }

        if (!TryGetClientOrigin(Handle, out var origin, out var width, out var height))
        {
            return false;
        }

        position = new Point(
            origin.X + (int)Math.Round(RelativeX * width),
            origin.Y + (int)Math.Round(RelativeY * height));
        return true;
    }

    private static bool TryGetClientOrigin(IntPtr hwnd, out NativeMethods.POINT origin, out int width, out int height)
    {
        origin = default;
        width = 0;
        height = 0;

        if (!NativeMethods.GetClientRect(hwnd, out var clientRect))
        {
            return false;
        }

        width = clientRect.Right - clientRect.Left;
        height = clientRect.Bottom - clientRect.Top;
        if (width <= 0 || height <= 0)
        {
            return false;
        }

        origin = new NativeMethods.POINT { X = 0, Y = 0 };
        NativeMethods.ClientToScreen(hwnd, ref origin);
        return true;
    }
}
