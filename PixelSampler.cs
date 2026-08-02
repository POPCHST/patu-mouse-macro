using System.Runtime.InteropServices;

namespace MouseMacro;

internal static class PixelSampler
{
    public static Color GetPixelColor(Point screenPosition)
    {
        var hdc = NativeMethods.GetDC(IntPtr.Zero);
        try
        {
            var colorRef = NativeMethods.GetPixel(hdc, screenPosition.X, screenPosition.Y);
            var r = (int)(colorRef & 0xFF);
            var g = (int)((colorRef >> 8) & 0xFF);
            var b = (int)((colorRef >> 16) & 0xFF);
            return Color.FromArgb(r, g, b);
        }
        finally
        {
            NativeMethods.ReleaseDC(IntPtr.Zero, hdc);
        }
    }
}
