namespace SdlSharp;

public enum SdlEventType : uint
{
	FirstEvent = 0, // Unused (do not remove)

	// Application events
	Quit = 0x100, // User-requested quit

	// These application events have special meaning on iOS, see README-ios.md for details
	Terminating,
	LowMemory,
	WillEnterBackground,
	DidEnterBackground,
	WillEnterForeground,
	DidEnterForeground,
	LocaleChanged,

	// Display events
	DisplayEvent = 0x150,

	// Window events
	WindowEvent = 0x200,
	SysWMEvent,

	// Keyboard events
	KeyDown = 0x300,
	KeyUp,
	TextEditing,
	TextInput,
	KeymapChanged,
	TextEditingExt,

	// Mouse events
	MouseMotion = 0x400,
	MouseButtonDown,
	MouseButtonUp,
	MouseWheel,

	// Joystick events
	JoyAxisMotion = 0x600,
	JoyBallMotion,
	JoyHatMotion,
	JoyButtonDown,
	JoyButtonUp,
	JoyDeviceAdded,
	JoyDeviceRemoved,
	JoyBetteryUpdated,

	// Game controller events
	ControllerAxisMotion = 0x650,
	ControllerButtonDown,
	ControllerButtonUp,
	ControllerDeviceAdded,
	ControllerDeviceRemoved,
	ControllerDeviceRemapped,
	ControllerTouchpadDown,
	ControllerTouchpadMotion,
	ControllerTouchpadUp,
	ControllerSensorUpdate,

	// Touch events
	FingerDown = 0x700,
	FingerUp,
	FingerMotion,

	// Gesture events
	DollarGesture = 0x800,
	DollarRecord,
	MultiGesture,

	// Clipboard events
	ClipboardUpdate = 0x900,

	// Drag and drop events
	DropFile = 0x1000,
	DropText,
	DropBegin,
	DropComplete,

	// Audio hotplug events
	AudioDeviceAdded = 0x1100,
	AudioDeviceRemoved,

	// Sensor events
	SensorUpdate = 0x1200,

	// Render events
	RenderTargetsReset = 0x2000,
	RenderDeviceReset,

	// Internal events
	PollSentinel = 0x7F00,

	UserEvent = 0x8000,
	LastEvent = 0xFFFF
}
