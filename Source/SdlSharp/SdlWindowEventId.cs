namespace SdlSharp;

public enum SdlWindowEventId : byte
{
	None, // Never used
	Shown, // Window has been shown
	Hidden, // Window has been hidden
	Exposed, // Window has been exposed and should be redrawn
	Moved, // Window has been moved to data1, data2
	Resized, // Window has been resized to data1xdata2
	SizeChanged, // The window size has changed, either as a result of an API call or through the system or user changing the window size.
	Minimized, // Window has been minimized
	Maximized, // Window has been maximized
	Restored, // Window has been restored to normal size and position
	Enter, // Window has gained mouse focus
	Leave, // Window has lost mouse focus
	FocusGained, // Window has gained keyboard focus
	FocusLost, // Window has lost keyboard focus
	Close, // The window manager requests that the window be closed
	TakeFocus, // Window is being offered a focus (should SetWindowInputFocus() on itself or a subwindow, or ignore)
	HitTest, // Window had a hit test that wasn't SDL_HITTEST_NORMAL.
	IccProfChanged, // The ICC profile of the window's display has changed.
	DisplayChanged // Window has been moved to display data1.
}