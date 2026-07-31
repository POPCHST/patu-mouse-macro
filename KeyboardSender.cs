using System.Runtime.InteropServices;

namespace MouseMacro;

internal static class KeyboardSender
{
    public static void PressKey(Keys key)
    {
        var inputs = new[] { CreateKeyInput((ushort)key, keyUp: false), CreateKeyInput((ushort)key, keyUp: true) };
        NativeMethods.SendInput((uint)inputs.Length, inputs, Marshal.SizeOf<NativeMethods.INPUT>());
    }

    private static NativeMethods.INPUT CreateKeyInput(ushort vk, bool keyUp)
    {
        var input = new NativeMethods.INPUT { type = NativeMethods.INPUT_KEYBOARD };
        input.U.ki.wVk = vk;
        input.U.ki.dwFlags = keyUp ? NativeMethods.KEYEVENTF_KEYUP : 0;
        return input;
    }
}
