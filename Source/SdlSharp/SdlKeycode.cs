﻿namespace SdlSharp;

public enum SdlKeycode
{
	Unknown = 0,

	Return = '\r',
	Escape = '\x1B',
	Backspace = '\b',
	Tab = '\t',
	Space = ' ',
	Exclaim = '!',
	Quotedbl = '"',
	Hash = '#',
	Percent = '%',
	Dollar = '$',
	Ampersand = '&',
	Quote = '\'',
	Leftparen = '(',
	Rightparen = ')',
	Asterisk = '*',
	Plus = '+',
	Comma = ',',
	Minus = '-',
	Period = '.',
	Slash = '/',
	N0 = '0',
	N1 = '1',
	N2 = '2',
	N3 = '3',
	N4 = '4',
	N5 = '5',
	N6 = '6',
	N7 = '7',
	N8 = '8',
	N9 = '9',
	Colon = ':',
	Semicolon = ';',
	Less = '<',
	Equals = '=',
	Greater = '>',
	Question = '?',
	At = '@',

	// Skip uppercase letters

	Leftbracket = '[',
	Backslash = '\\',
	Rightbracket = ']',
	Caret = '^',
	Underscore = '_',
	Backquote = '`',
	A = 'a',
	B = 'b',
	C = 'c',
	D = 'd',
	E = 'e',
	F = 'f',
	G = 'g',
	H = 'h',
	I = 'i',
	J = 'j',
	K = 'k',
	L = 'l',
	M = 'm',
	N = 'n',
	O = 'o',
	P = 'p',
	Q = 'q',
	R = 'r',
	S = 's',
	T = 't',
	U = 'u',
	V = 'v',
	W = 'w',
	X = 'x',
	Y = 'y',
	Z = 'z',

	Capslock = (1 << 30) | SdlScancode.Capslock,

	F1 = (1 << 30) | SdlScancode.F1,
	F2 = (1 << 30) | SdlScancode.F2,
	F3 = (1 << 30) | SdlScancode.F3,
	F4 = (1 << 30) | SdlScancode.F4,
	F5 = (1 << 30) | SdlScancode.F5,
	F6 = (1 << 30) | SdlScancode.F6,
	F7 = (1 << 30) | SdlScancode.F7,
	F8 = (1 << 30) | SdlScancode.F8,
	F9 = (1 << 30) | SdlScancode.F9,
	F10 = (1 << 30) | SdlScancode.F10,
	F11 = (1 << 30) | SdlScancode.F11,
	F12 = (1 << 30) | SdlScancode.F12,

	PrintScreen = (1 << 30) | SdlScancode.PrintScreen,
	ScrollLock = (1 << 30) | SdlScancode.ScrollLock,
	Pause = (1 << 30) | SdlScancode.Pause,
	Insert = (1 << 30) | SdlScancode.Insert,
	Home = (1 << 30) | SdlScancode.Home,
	PageUp = (1 << 30) | SdlScancode.PageUp,
	Delete = '\x7F',
	End = (1 << 30) | SdlScancode.End,
	PageDown = (1 << 30) | SdlScancode.PageDown,
	Right = (1 << 30) | SdlScancode.Right,
	Left = (1 << 30) | SdlScancode.Left,
	Down = (1 << 30) | SdlScancode.Down,
	Up = (1 << 30) | SdlScancode.Up,

	NumlockClear = (1 << 30) | SdlScancode.NumlockClear,
	KpDivide = (1 << 30) | SdlScancode.KpDivide,
	KpMultiply = (1 << 30) | SdlScancode.KpMultiply,
	KpMinus = (1 << 30) | SdlScancode.KpMinus,
	KpPlus = (1 << 30) | SdlScancode.KpPlus,
	KpEnter = (1 << 30) | SdlScancode.KpEnter,
	Kp1 = (1 << 30) | SdlScancode.Kp1,
	Kp2 = (1 << 30) | SdlScancode.Kp2,
	Kp3 = (1 << 30) | SdlScancode.Kp3,
	Kp4 = (1 << 30) | SdlScancode.Kp4,
	Kp5 = (1 << 30) | SdlScancode.Kp5,
	Kp6 = (1 << 30) | SdlScancode.Kp6,
	Kp7 = (1 << 30) | SdlScancode.Kp7,
	Kp8 = (1 << 30) | SdlScancode.Kp8,
	Kp9 = (1 << 30) | SdlScancode.Kp9,
	Kp0 = (1 << 30) | SdlScancode.Kp0,
	KpPeriod = (1 << 30) | SdlScancode.KpPeriod,

	Application = (1 << 30) | SdlScancode.Application,
	Power = (1 << 30) | SdlScancode.Power,
	KpEquals = (1 << 30) | SdlScancode.KpEquals,
	F13 = (1 << 30) | SdlScancode.F13,
	F14 = (1 << 30) | SdlScancode.F14,
	F15 = (1 << 30) | SdlScancode.F15,
	F16 = (1 << 30) | SdlScancode.F16,
	F17 = (1 << 30) | SdlScancode.F17,
	F18 = (1 << 30) | SdlScancode.F18,
	F19 = (1 << 30) | SdlScancode.F19,
	F20 = (1 << 30) | SdlScancode.F20,
	F21 = (1 << 30) | SdlScancode.F21,
	F22 = (1 << 30) | SdlScancode.F22,
	F23 = (1 << 30) | SdlScancode.F23,
	F24 = (1 << 30) | SdlScancode.F24,
	Execute = (1 << 30) | SdlScancode.Execute,
	Help = (1 << 30) | SdlScancode.Help,
	Menu = (1 << 30) | SdlScancode.Menu,
	Select = (1 << 30) | SdlScancode.Select,
	Stop = (1 << 30) | SdlScancode.Stop,
	Again = (1 << 30) | SdlScancode.Again,
	Undo = (1 << 30) | SdlScancode.Undo,
	Cut = (1 << 30) | SdlScancode.Cut,
	Copy = (1 << 30) | SdlScancode.Copy,
	Paste = (1 << 30) | SdlScancode.Paste,
	Find = (1 << 30) | SdlScancode.Find,
	Mute = (1 << 30) | SdlScancode.Mute,
	VolumeUp = (1 << 30) | SdlScancode.VolumeUp,
	VolumeDown = (1 << 30) | SdlScancode.VolumeDown,
	KpComma = (1 << 30) | SdlScancode.KpComma,

	KpEqualsAs400 = (1 << 30) | SdlScancode.KpEqualsAs400,

	AltErase = (1 << 30) | SdlScancode.AltErase,
	SysReq = (1 << 30) | SdlScancode.SysReq,
	Cancel = (1 << 30) | SdlScancode.Cancel,
	Clear = (1 << 30) | SdlScancode.Clear,
	Prior = (1 << 30) | SdlScancode.Prior,
	Return2 = (1 << 30) | SdlScancode.Return2,
	Separator = (1 << 30) | SdlScancode.Separator,
	Out = (1 << 30) | SdlScancode.Out,
	Oper = (1 << 30) | SdlScancode.Oper,
	ClearAgain = (1 << 30) | SdlScancode.ClearAgain,
	CrSel = (1 << 30) | SdlScancode.CrSel,
	ExSel = (1 << 30) | SdlScancode.ExSel,

	Kp00 = (1 << 30) | SdlScancode.Kp00,
	Kp000 = (1 << 30) | SdlScancode.Kp000,
	ThousandsSeparator = (1 << 30) | SdlScancode.ThousandsSeparator,
	DecimalSeparator = (1 << 30) | SdlScancode.DecimalSeparator,
	CurrencyUnit = (1 << 30) | SdlScancode.CurrencyUnit,
	CurrencySubunit = (1 << 30) | SdlScancode.CurrencySubunit,
	KpLeftParen = (1 << 30) | SdlScancode.KpLeftParen,
	KpRightParen = (1 << 30) | SdlScancode.KpRightParen,
	KpLeftBrace = (1 << 30) | SdlScancode.KpLeftBrace,
	KpRightBrace = (1 << 30) | SdlScancode.KpRightBrace,
	KpTab = (1 << 30) | SdlScancode.KpTab,
	KpBackspace = (1 << 30) | SdlScancode.KpBackspace,
	KpA = (1 << 30) | SdlScancode.KpA,
	KpB = (1 << 30) | SdlScancode.KpB,
	KpC = (1 << 30) | SdlScancode.KpC,
	KpD = (1 << 30) | SdlScancode.KpD,
	KpE = (1 << 30) | SdlScancode.KpE,
	KpF = (1 << 30) | SdlScancode.KpF,
	KpXor = (1 << 30) | SdlScancode.KpXor,
	KpPower = (1 << 30) | SdlScancode.KpPower,
	KpPercent = (1 << 30) | SdlScancode.KpPercent,
	KpLess = (1 << 30) | SdlScancode.KpLess,
	KpGreater = (1 << 30) | SdlScancode.KpGreater,
	KpAmpersand = (1 << 30) | SdlScancode.KpAmpersand,
	KpDblAmpersand = (1 << 30) | SdlScancode.KpDblAmpersand,
	KpVerticalBar = (1 << 30) | SdlScancode.KpVerticalBar,
	KpDblVerticalBar = (1 << 30) | SdlScancode.KpDblVerticalBar,
	KpColon = (1 << 30) | SdlScancode.KpColon,
	KpHash = (1 << 30) | SdlScancode.KpHash,
	KpSpace = (1 << 30) | SdlScancode.KpSpace,
	KpAt = (1 << 30) | SdlScancode.KpAt,
	KpExclam = (1 << 30) | SdlScancode.KpExclam,
	KpMemStore = (1 << 30) | SdlScancode.KpMemStore,
	KpMemRecall = (1 << 30) | SdlScancode.KpMemRecall,
	KpMemClear = (1 << 30) | SdlScancode.KpMemClear,
	KpMemAdd = (1 << 30) | SdlScancode.KpMemAdd,
	KpMemSubtract = (1 << 30) | SdlScancode.KpMemSubtract,
	KpMemMultiply = (1 << 30) | SdlScancode.KpMemMultiply,
	KpMemDivide = (1 << 30) | SdlScancode.KpMemDivide,
	KpPlusMinus = (1 << 30) | SdlScancode.KpPlusMinus,
	KpClear = (1 << 30) | SdlScancode.KpClear,
	KpClearEntry = (1 << 30) | SdlScancode.KpClearEntry,
	KpBinary = (1 << 30) | SdlScancode.KpBinary,
	KpOctal = (1 << 30) | SdlScancode.KpOctal,
	KpDecimal = (1 << 30) | SdlScancode.KpDecimal,
	KpHexadecimal = (1 << 30) | SdlScancode.KpHexadecimal,

	LCtrl = (1 << 30) | SdlScancode.LCtrl,
	LShift = (1 << 30) | SdlScancode.LShift,
	LAlt = (1 << 30) | SdlScancode.LAlt,
	LGui = (1 << 30) | SdlScancode.LGui,
	RCtrl = (1 << 30) | SdlScancode.RCtrl,
	RShift = (1 << 30) | SdlScancode.RShift,
	RAlt = (1 << 30) | SdlScancode.RAlt,
	RGui = (1 << 30) | SdlScancode.RGui,

	Mode = (1 << 30) | SdlScancode.Mode,

	AudioNext = (1 << 30) | SdlScancode.AudioNext,
	AudioPrev = (1 << 30) | SdlScancode.AudioPrev,
	AudioStop = (1 << 30) | SdlScancode.AudioStop,
	AudioPlay = (1 << 30) | SdlScancode.AudioPlay,
	AudioMute = (1 << 30) | SdlScancode.AudioMute,
	MediaSelect = (1 << 30) | SdlScancode.MediaSelect,
	Www = (1 << 30) | SdlScancode.Www,
	Mail = (1 << 30) | SdlScancode.Mail,
	Calculator = (1 << 30) | SdlScancode.Calculator,
	Computer = (1 << 30) | SdlScancode.Computer,
	AcSearch = (1 << 30) | SdlScancode.AcSearch,
	AcHome = (1 << 30) | SdlScancode.AcHome,
	AcBack = (1 << 30) | SdlScancode.AcBack,
	AcForward = (1 << 30) | SdlScancode.AcForward,
	AcStop = (1 << 30) | SdlScancode.AcStop,
	AcRefresh = (1 << 30) | SdlScancode.AcRefresh,
	AcBookmarks = (1 << 30) | SdlScancode.AcBookmarks,

	BrightnessDown = (1 << 30) | SdlScancode.BrightnessDown,
	BrightnessUp = (1 << 30) | SdlScancode.BrightnessUp,
	DisplaySwitch = (1 << 30) | SdlScancode.DisplaySwitch,
	KbdIllumToggle = (1 << 30) | SdlScancode.KbdIllumToggle,
	KbdIllumDown = (1 << 30) | SdlScancode.KbdIllumDown,
	KbdIllumUp = (1 << 30) | SdlScancode.KbdIllumUp,
	Eject = (1 << 30) | SdlScancode.Eject,
	Sleep = (1 << 30) | SdlScancode.Sleep,
	App1 = (1 << 30) | SdlScancode.App1,
	App2 = (1 << 30) | SdlScancode.App2,

	AudioRewind = (1 << 30) | SdlScancode.AudioRewind,
	AudioFastForward = (1 << 30) | SdlScancode.AudioFastForward,

	SoftLeft = (1 << 30) | SdlScancode.SoftLeft,
	SoftRight = (1 << 30) | SdlScancode.SoftRight,
	Call = (1 << 30) | SdlScancode.Call,
	EndCall = (1 << 30) | SdlScancode.EndCall
}