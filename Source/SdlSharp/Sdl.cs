using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SdlSharp;

public class Sdl
{
	private delegate nint ProcGetError();
	private delegate SdlErrorCode ProcInit(SdlInitFlags flags);
	private delegate void ProcQuit();
	private delegate SdlWindowPtr ProcCreateWindow([MarshalAs(UnmanagedType.LPUTF8Str)] string title, int x, int y, int w, int h, SdlWindowFlags flags);
	private delegate SdlErrorCode ProcDestroyWindow(SdlWindowPtr window);
	private delegate void ProcShowWindow(SdlWindowPtr window);
	private delegate void ProcHideWindow(SdlWindowPtr window);
	private delegate SdlWindowFlags ProcGetWindowFlags(SdlWindowPtr window);

	[return: MarshalAs(UnmanagedType.I1)]
	private delegate bool ProcPollEvent(out SdlEvent @event);

	private delegate uint ProcGetWindowID(SdlWindowPtr window);
	private delegate void ProcGetWindowSize(SdlWindowPtr window, out int w, out int h);
	private delegate void ProcSetWindowSize(SdlWindowPtr window, int w, int h);
	private delegate void ProcGL_SwapWindow(SdlWindowPtr window);
	private delegate SdlGLContext ProcGL_CreateContext(SdlWindowPtr window);
	private delegate void ProcGL_DeleteContext(SdlGLContext context);
	private delegate SdlErrorCode ProcGL_MakeCurrent(SdlWindowPtr window, SdlGLContext context);
	private delegate nint ProcGL_GetProcAddress([MarshalAs(UnmanagedType.LPUTF8Str)] string proc);
	private delegate void ProcGL_GetDrawableSize(SdlWindowPtr window, out int w, out int h);

	private readonly ProcGetError procGetError;
	private readonly ProcInit procInit;
	private readonly ProcQuit procQuit;
	private readonly ProcCreateWindow procCreateWindow;
	private readonly ProcDestroyWindow procDestroyWindow;
	private readonly ProcShowWindow procShowWindow;
	private readonly ProcHideWindow procHideWindow;
	private readonly ProcGetWindowFlags procGetWindowFlags;
	private readonly ProcPollEvent procPollEvent;
	private readonly ProcGetWindowID procGetWindowID;
	private readonly ProcGetWindowSize procGetWindowSize;
	private readonly ProcSetWindowSize procSetWindowSize;
	private readonly ProcGL_SwapWindow procGL_SwapWindow;
	private readonly ProcGL_CreateContext procGL_CreateContext;
	private readonly ProcGL_DeleteContext procGL_DeleteContext;
	private readonly ProcGL_MakeCurrent procGL_MakeCurrent;
	private readonly ProcGL_GetProcAddress procGL_GetProcAddress;
	private readonly ProcGL_GetDrawableSize procGL_GetDrawableSize;

	private readonly nint handle;

	private static Sdl? instance;

	private static Sdl Instance => instance ??= new();

	private static string libraryPath = "SDL2";
	
	private Sdl()
	{
		if (!NativeLibrary.TryLoad(libraryPath, out handle) || handle == 0)
			throw new("Failed to load the native SDL2 library.");

		procGetError = Marshal.GetDelegateForFunctionPointer<ProcGetError>(NativeLibrary.GetExport(handle, "SDL_GetError"));
		procInit = Marshal.GetDelegateForFunctionPointer<ProcInit>(NativeLibrary.GetExport(handle, "SDL_Init"));
		procQuit = Marshal.GetDelegateForFunctionPointer<ProcQuit>(NativeLibrary.GetExport(handle, "SDL_Quit"));
		procCreateWindow = Marshal.GetDelegateForFunctionPointer<ProcCreateWindow>(NativeLibrary.GetExport(handle, "SDL_CreateWindow"));
		procDestroyWindow = Marshal.GetDelegateForFunctionPointer<ProcDestroyWindow>(NativeLibrary.GetExport(handle, "SDL_DestroyWindow"));
		procShowWindow = Marshal.GetDelegateForFunctionPointer<ProcShowWindow>(NativeLibrary.GetExport(handle, "SDL_ShowWindow"));
		procHideWindow = Marshal.GetDelegateForFunctionPointer<ProcHideWindow>(NativeLibrary.GetExport(handle, "SDL_HideWindow"));
		procGetWindowFlags = Marshal.GetDelegateForFunctionPointer<ProcGetWindowFlags>(NativeLibrary.GetExport(handle, "SDL_GetWindowFlags"));
		procPollEvent = Marshal.GetDelegateForFunctionPointer<ProcPollEvent>(NativeLibrary.GetExport(handle, "SDL_PollEvent"));
		procGetWindowID = Marshal.GetDelegateForFunctionPointer<ProcGetWindowID>(NativeLibrary.GetExport(handle, "SDL_GetWindowID"));
		procGetWindowSize = Marshal.GetDelegateForFunctionPointer<ProcGetWindowSize>(NativeLibrary.GetExport(handle, "SDL_GetWindowSize"));
		procSetWindowSize = Marshal.GetDelegateForFunctionPointer<ProcSetWindowSize>(NativeLibrary.GetExport(handle, "SDL_SetWindowSize"));
		procGL_SwapWindow = Marshal.GetDelegateForFunctionPointer<ProcGL_SwapWindow>(NativeLibrary.GetExport(handle, "SDL_GL_SwapWindow"));
		procGL_CreateContext = Marshal.GetDelegateForFunctionPointer<ProcGL_CreateContext>(NativeLibrary.GetExport(handle, "SDL_GL_CreateContext"));
		procGL_DeleteContext = Marshal.GetDelegateForFunctionPointer<ProcGL_DeleteContext>(NativeLibrary.GetExport(handle, "SDL_GL_DeleteContext"));
		procGL_MakeCurrent = Marshal.GetDelegateForFunctionPointer<ProcGL_MakeCurrent>(NativeLibrary.GetExport(handle, "SDL_GL_MakeCurrent"));
		procGL_GetProcAddress = Marshal.GetDelegateForFunctionPointer<ProcGL_GetProcAddress>(NativeLibrary.GetExport(handle, "SDL_GL_GetProcAddress"));
		procGL_GetDrawableSize = Marshal.GetDelegateForFunctionPointer<ProcGL_GetDrawableSize>(NativeLibrary.GetExport(handle, "SDL_GL_GetDrawableSize"));
	}

	public static void SetLibraryPath(string name) => libraryPath = name;
	
	/* 
	 * #define SDL_WINDOWPOS_UNDEFINED_MASK    0x1FFF0000u
	 * #define SDL_WINDOWPOS_UNDEFINED_DISPLAY(X)  (SDL_WINDOWPOS_UNDEFINED_MASK|(X))
	 * #define SDL_WINDOWPOS_UNDEFINED         SDL_WINDOWPOS_UNDEFINED_DISPLAY(0)
	 */

	private const int WindowposUndefinedMask = (int)0x1FFF0000u;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int WindowposUndefinedDisplay(uint x) => (int)(WindowposUndefinedMask | x);

	public static int WindowposUndefined { get; } = WindowposUndefinedDisplay(0);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string GetError() => Marshal.PtrToStringUTF8(Instance.procGetError()) ?? throw new UnreachableException("SDL_GetError returned NULL.");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlErrorCode Init(SdlInitFlags flags) => Instance.procInit(flags);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Quit() => Instance.procQuit();

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlWindowPtr CreateWindow(string title, int x, int y, int w, int h, SdlWindowFlags flags) => Instance.procCreateWindow(title, x, y, w, h, flags);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlWindowPtr CreateWindow(string title, int w, int h, SdlWindowFlags flags) =>
		Instance.procCreateWindow(title, WindowposUndefined, WindowposUndefined, w, h, flags);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlErrorCode DestroyWindow(SdlWindowPtr window) => Instance.procDestroyWindow(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ShowWindow(SdlWindowPtr window) => Instance.procShowWindow(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void HideWindow(SdlWindowPtr window) => Instance.procHideWindow(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlWindowFlags GetWindowFlags(SdlWindowPtr window) => Instance.procGetWindowFlags(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool PollEvent(out SdlEvent @event) => Instance.procPollEvent(out @event);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint GetWindowID(SdlWindowPtr window) => Instance.procGetWindowID(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void GL_SwapWindow(SdlWindowPtr window) => Instance.procGL_SwapWindow(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlGLContext GL_CreateContext(SdlWindowPtr window) => Instance.procGL_CreateContext(window);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void GL_DeleteContext(SdlGLContext context) => Instance.procGL_DeleteContext(context);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SdlErrorCode GL_MakeCurrent(SdlWindowPtr window, SdlGLContext context) => Instance.procGL_MakeCurrent(window, context);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static nint GL_GetProcAddress(string proc) => Instance.procGL_GetProcAddress(proc);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void GetWindowSize(SdlWindowPtr window, out int w, out int h) => Instance.procGetWindowSize(window, out w, out h);

	public static void GL_GetDrawableSize(SdlWindowPtr window, out int w, out int h) => Instance.procGL_GetDrawableSize(window, out w, out h);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SetWindowSize(SdlWindowPtr window, int w, int h) => Instance.procSetWindowSize(window, w, h);
}
