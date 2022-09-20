namespace Webmaster442.WindowsTerminalFragment;

/// <summary>
/// Controls what happens when the application emits a BEL character. When set to "all", the terminal will play a sound and flash the taskbar icon. When the terminal is not in focus, only the taskbar icon will flash.
/// </summary>
public enum BellStyle
{
    All,
    Audible,
    Window,
    Taskbar,
    None,
}
