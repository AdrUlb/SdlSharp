using System.Runtime.InteropServices;

namespace SdlSharp;

[StructLayout(LayoutKind.Sequential)]
public struct SdlKeysym
{
	public SdlScancode Scancode;   // SDL physical key code - see ::SDL_Scancode for details
	public SdlKeycode Sym;     // SDL virtual key code - see ::SDL_Keycode for details
	public ushort Mod;             // current key modifiers
	public uint Unused;
}
