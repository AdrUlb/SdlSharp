namespace SdlSharp;

[Flags]
public enum SdlButtonMask : uint
{
	ButtonLeft = 1 << (SdlButton.Left - 1),
	ButtonMiddle = 1 << (SdlButton.Middle - 1),
	ButtonRight = 1 << (SdlButton.Right - 1),
	ButtonX1 = 1 << (SdlButton.X1 - 1),
	ButtonX2 = 1 << (SdlButton.X2 - 1),
}
