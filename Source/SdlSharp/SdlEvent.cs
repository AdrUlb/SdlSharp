using System.Runtime.InteropServices;

namespace SdlSharp;

[StructLayout(LayoutKind.Sequential)]
public readonly struct SdlWindowEvent
{
	public readonly SdlEventType Type;       // ::SDL_WINDOWEVENT
	public readonly uint Timestamp;          // In milliseconds, populated using SDL_GetTicks()
	public readonly uint WindowID;           // The associated window
	public readonly SdlWindowEventId Event;  // ::SDL_WindowEventID
	public readonly byte Padding1;
	public readonly byte Padding2;
	public readonly byte Padding3;
	public readonly int Data1;               // event dependent data
	public readonly int Data2;               // event dependent data
}

[StructLayout(LayoutKind.Sequential)]
public readonly struct SdlKeyboardEvent
{
	public readonly SdlEventType Type;	// ::SDL_KEYDOWN or ::SDL_KEYUP
	public readonly uint Timestamp;		// In milliseconds, populated using SDL_GetTicks()
	public readonly uint WindowID;		// The window with keyboard focus, if any
	public readonly SdlKeyState State;	// ::SDL_PRESSED or ::SDL_RELEASED
	public readonly byte Repeat;			// Non-zero if this is a key repeat
	public readonly byte Padding2;
	public readonly byte Padding3;
	public readonly SdlKeysym keysym;	// The key that was pressed or released
}

[StructLayout(LayoutKind.Sequential)]
public readonly struct SdlMouseMotionEvent
{
	public readonly SdlEventType type;       // ::SDL_MOUSEMOTION
	public readonly uint Timestamp;          // In milliseconds, populated using SDL_GetTicks()
	public readonly uint WindowID;           // The window with mouse focus, if any
	public readonly uint Which;              // The mouse instance id, or SDL_TOUCH_MOUSEID
	public readonly SdlButtonMask State;     // The current button state
	public readonly int X;                   // X coordinate, relative to window
	public readonly int Y;                   // Y coordinate, relative to window
	public readonly int XRel;                // The relative motion in the X direction
	public readonly int YRel;                // The relative motion in the Y direction
}

[StructLayout(LayoutKind.Sequential)]
public readonly struct SdlMouseButtonEvent
{
	public readonly SdlEventType Type;	// ::SDL_MOUSEBUTTONDOWN or ::SDL_MOUSEBUTTONUP
	public readonly uint Timestamp;		// In milliseconds, populated using SDL_GetTicks()
	public readonly uint WindowID;		// The window with mouse focus, if any
	public readonly uint Which;			// The mouse instance id, or SDL_TOUCH_MOUSEID
	public readonly SdlButton Button;	// The mouse button index
	public readonly SdlKeyState State;	// ::SDL_PRESSED or ::SDL_RELEASED
	public readonly byte Clicks;			// 1 for single-click, 2 for double-click, etc.
	public readonly byte Padding1;
	public readonly int X;				// X coordinate, relative to window
	public readonly int Y;				// Y coordinate, relative to window
}

[StructLayout(LayoutKind.Explicit, Size = 56)]
public readonly struct SdlEvent
{
	[FieldOffset(0)]
	public readonly SdlEventType Type;                       // Event type, shared with all events

	/*[FieldOffset(0)]
	public SdlCommonEvent Common;                   // Common event data

	[FieldOffset(0)]
	public SdlDisplayEvent Display;                 // Display event data
	*/
	[FieldOffset(0)]
	public readonly SdlWindowEvent Window;                   // Window event data

	[FieldOffset(0)]
	public readonly SdlKeyboardEvent Key;                    // Keyboard event data
	
	/*[FieldOffset(0)]
	public SdlTextEditingEvent Edit;                // Text editing event data

	[FieldOffset(0)]
	public SdlTextEditingExtEvent EditExt;          // Extended text editing event data

	[FieldOffset(0)]
	public SdlTextInputEvent Text;                  // Text input event data
	*/
	[FieldOffset(0)]
	public readonly SdlMouseMotionEvent Motion;              // Mouse motion event data

	[FieldOffset(0)]
	public readonly SdlMouseButtonEvent Button;              // Mouse button event data
	/*
	[FieldOffset(0)]
	public SdlMouseWheelEvent Wheel;                // Mouse wheel event data

	[FieldOffset(0)]
	public SdlJoyAxisEvent JAxis;                   // Joystick axis event data

	[FieldOffset(0)]
	public SdlJoyBallEvent JBall;                   // Joystick ball event data

	[FieldOffset(0)]
	public SdlJoyHatEvent JHat;                     // Joystick hat event data

	[FieldOffset(0)]
	public SdlJoyButtonEvent JButton;               // Joystick button event data

	[FieldOffset(0)]
	public SdlJoyDeviceEvent JDevice;               // Joystick device change event data

	[FieldOffset(0)]
	public SdlJoyBatteryEvent JBattery;             // Joystick battery event data

	[FieldOffset(0)]
	public SdlControllerAxisEvent CAxis;            // Game Controller axis event data

	[FieldOffset(0)]
	public SdlControllerButtonEvent CButton;        // Game Controller button event data

	[FieldOffset(0)]
	public SdlControllerDeviceEvent CDevice;        // Game Controller device event data

	[FieldOffset(0)]
	public SdlControllerTouchpadEvent CTouchpad;    // Game Controller touchpad event data

	[FieldOffset(0)]
	public SdlControllerSensorEvent CSensor;        // Game Controller sensor event data

	[FieldOffset(0)]
	public SdlAudioDeviceEvent ADevice;             // Audio device event data

	[FieldOffset(0)]
	public SdlSensorEvent Sensor;                   // Sensor event data

	[FieldOffset(0)]
	public SdlQuitEvent Quit;                       // Quit request event data

	[FieldOffset(0)]
	public SdlUserEvent User;                       // Custom event data

	[FieldOffset(0)]
	public SdlSysWMEvent SysWM;                     // System dependent window event data

	[FieldOffset(0)]
	public SdlTouchFingerEvent TFinger;             // Touch finger event data

	[FieldOffset(0)]
	public SdlMultiGestureEvent MGesture;           // Gesture event data

	[FieldOffset(0)]
	public SdlDollarGestureEvent DGesture;          // Gesture event data

	[FieldOffset(0)]
	public SdlDropEvent Drop;                       // Drag and drop event data
	*/
}
