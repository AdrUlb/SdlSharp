namespace SdlSharp;

public enum SdlInitFlags : uint
{
	Timer = 0x00000001,
	Audio = 0x00000010,
	Video = 0x00000020,             // implies SDL_INIT_EVENTS
	Joystick = 0x00000200,          // implies SDL_INIT_EVENTS
	Haptic = 0x00001000,
	GameController = 0x00002000,    // implies SDL_INIT_JOYSTICK
	Events = 0x00004000,
	Sensor = 0x00008000,
	Everything = Timer | Audio | Video | Events | Joystick | Haptic | GameController | Sensor
}
