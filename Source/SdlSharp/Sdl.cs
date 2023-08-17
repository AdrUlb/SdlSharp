using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SdlSharp;

public static partial class Sdl
{
	public const string LibraryName = "SDL2";
	
	/* 
	 * #define SDL_WINDOWPOS_UNDEFINED_MASK    0x1FFF0000u
	 * #define SDL_WINDOWPOS_UNDEFINED_DISPLAY(X)  (SDL_WINDOWPOS_UNDEFINED_MASK|(X))
	 * #define SDL_WINDOWPOS_UNDEFINED         SDL_WINDOWPOS_UNDEFINED_DISPLAY(0)
	 */
    
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetError")]
	private static partial nint NativeGetError();
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_Init")]
	private static partial SdlErrorCode NativeInit(SdlInitFlags flags);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_Quit")]
	private static partial void NativeQuit();
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindow")]
	private static partial SdlWindowPtr NativeCreateWindow([MarshalAs(UnmanagedType.LPUTF8Str)] string title, int x, int y, int w, int h, SdlWindowFlags flags);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyWindow")]
	private static partial SdlErrorCode NativeDestroyWindow(SdlWindowPtr window);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowWindow")]
	private static partial void NativeShowWindow(SdlWindowPtr window);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_HideWindow")]
	private static partial void NativeHideWindow(SdlWindowPtr window);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFlags")]
	private static partial SdlWindowFlags NativeGetWindowFlags(SdlWindowPtr window);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_PollEvent")]
	private static partial int NativePollEvent(out SdlEvent @event);

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowID")]
	private static partial uint NativeGetWindowID(SdlWindowPtr window);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSize")]
	private static partial void NativeGetWindowSize(SdlWindowPtr window, out int w, out int h);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowSize")]
	private static partial void NativeSetWindowSize(SdlWindowPtr window, int w, int h);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_SwapWindow")]
	private static partial void NativeGL_SwapWindow(SdlWindowPtr window);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_CreateContext")]
	private static partial SdlGLContext NativeGL_CreateContext(SdlWindowPtr window);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_DeleteContext")]
	private static partial void NativeGL_DeleteContext(SdlGLContext context);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_MakeCurrent")]
	private static partial SdlErrorCode NativeGL_MakeCurrent(SdlWindowPtr window, SdlGLContext context);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetProcAddress")]
	private static partial nint NativeGL_GetProcAddress([MarshalAs(UnmanagedType.LPUTF8Str)] string proc);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetDrawableSize")]
	private static partial void NativeGL_GetDrawableSize(SdlWindowPtr window, out int w, out int h);
	
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_SetSwapInterval")]
	private static partial SdlErrorCode NativeGL_SetSwapInterval(int interval);

	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_SetAttribute")]
	private static partial SdlErrorCode NativeGL_SetAttribute(SdlGlAttribute attr, int value);
	
	private const int WindowposUndefinedMask = (int)0x1FFF0000u;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int WindowposUndefinedDisplay(uint x) => (int)(WindowposUndefinedMask | x);

	public static int WindowposUndefined { get; } = WindowposUndefinedDisplay(0);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string GetError() => Marshal.PtrToStringUTF8(NativeGetError()) ?? throw new UnreachableException("SDL_GetError returned NULL.");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlErrorCode Init(SdlInitFlags flags) => NativeInit(flags);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Quit() => NativeQuit();

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlWindowPtr CreateWindow(string title, int x, int y, int w, int h, SdlWindowFlags flags) => NativeCreateWindow(title, x, y, w, h, flags);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlWindowPtr CreateWindow(string title, int w, int h, SdlWindowFlags flags) =>
		NativeCreateWindow(title, WindowposUndefined, WindowposUndefined, w, h, flags);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlErrorCode DestroyWindow(SdlWindowPtr window) => NativeDestroyWindow(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ShowWindow(SdlWindowPtr window) => NativeShowWindow(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void HideWindow(SdlWindowPtr window) => NativeHideWindow(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlWindowFlags GetWindowFlags(SdlWindowPtr window) => NativeGetWindowFlags(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool PollEvent(out SdlEvent @event) => NativePollEvent(out @event) != 0;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint GetWindowID(SdlWindowPtr window) => NativeGetWindowID(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void GL_SwapWindow(SdlWindowPtr window) => NativeGL_SwapWindow(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlGLContext GL_CreateContext(SdlWindowPtr window) => NativeGL_CreateContext(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void GL_DeleteContext(SdlGLContext context) => NativeGL_DeleteContext(context);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlErrorCode GL_MakeCurrent(SdlWindowPtr window, SdlGLContext context) => NativeGL_MakeCurrent(window, context);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static nint GL_GetProcAddress(string proc) => NativeGL_GetProcAddress(proc);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void GetWindowSize(SdlWindowPtr window, out int w, out int h) => NativeGetWindowSize(window, out w, out h);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SetWindowSize(SdlWindowPtr window, int w, int h) => NativeSetWindowSize(window, w, h);
	
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void GL_GetDrawableSize(SdlWindowPtr window, out int w, out int h) => NativeGL_GetDrawableSize(window, out w, out h);
	
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlErrorCode GL_SetSwapInterval(int interval) => NativeGL_SetSwapInterval(interval);


	public static SdlErrorCode GL_SetAttribute(SdlGlAttribute attr, int value) => NativeGL_SetAttribute(attr, value);
	public static SdlErrorCode GL_SetAttribute(SdlGlAttribute attr, SdlGlProfile value) => NativeGL_SetAttribute(attr, (int)value);
}
