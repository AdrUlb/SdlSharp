using System.Runtime.InteropServices;

namespace SdlSharp;

[StructLayout(LayoutKind.Sequential, Pack = 0)]
public readonly struct SdlWindowPtr
{
	private readonly nint ptr;

	private SdlWindowPtr(nint ptr)
	{
		this.ptr = ptr;
	}

	public static implicit operator nint(SdlWindowPtr value) => value.ptr;
	public static implicit operator SdlWindowPtr(nint value) => new(value);
}
