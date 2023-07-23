using System.Runtime.InteropServices;

namespace SdlSharp;

[StructLayout(LayoutKind.Sequential, Pack = 0)]
public readonly struct SdlGLContext
{
	private readonly nint ptr;

	private SdlGLContext(nint ptr)
	{
		this.ptr = ptr;
	}

	public static implicit operator nint(SdlGLContext value) => value.ptr;
	public static implicit operator SdlGLContext(nint value) => new(value);
}
