namespace SdlSharp;

[Flags]
public enum SdlWindowFlags : uint
{
	OpenGl = 0x00000002,
	Shown = 0x00000004,
	Hidden = 0x00000008,
	Resizable = 0x00000020
}
