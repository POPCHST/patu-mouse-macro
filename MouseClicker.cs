using System.Runtime.InteropServices;

namespace MouseMacro;

internal enum MouseButtonType
{
    Left,
    Right,
    Middle
}

internal static class MouseClicker
{
    public static void ClickAt(Point position, MouseButtonType button)
    {
        Cursor.Position = position;

        var (down, up) = button switch
        {
            MouseButtonType.Right => (NativeMethods.MOUSEEVENTF_RIGHTDOWN, NativeMethods.MOUSEEVENTF_RIGHTUP),
            MouseButtonType.Middle => (NativeMethods.MOUSEEVENTF_MIDDLEDOWN, NativeMethods.MOUSEEVENTF_MIDDLEUP),
            _ => (NativeMethods.MOUSEEVENTF_LEFTDOWN, NativeMethods.MOUSEEVENTF_LEFTUP)
        };

        var inputs = new[] { CreateMouseInput(down), CreateMouseInput(up) };
        NativeMethods.SendInput((uint)inputs.Length, inputs, Marshal.SizeOf<NativeMethods.INPUT>());
    }

    private static NativeMethods.INPUT CreateMouseInput(uint flags)
    {
        var input = new NativeMethods.INPUT { type = NativeMethods.INPUT_MOUSE };
        input.U.mi.dwFlags = flags;
        return input;
    }
}
