namespace Webmaster442.WindowsTerminalFragment;

/// <summary>
/// Controls what happens when the application emits a BEL character. When set to "all", the terminal will play a sound and flash the taskbar icon. When the terminal is not in focus, only the taskbar icon will flash.
/// </summary>
public enum BellStyle
{
    /// <summary>
    /// will play a sound and flash the taskbar icon. When the terminal is not in focus, only the taskbar icon will flash
    /// </summary>
    All,
    /// <summary>
    /// Only play a sound
    /// </summary>
    Audible,
    /// <summary>
    /// Only flash the window
    /// </summary>
    Window,
    /// <summary>
    /// Only flash the taskbar icon
    /// </summary>
    Taskbar,
    /// <summary>
    /// Do nothing
    /// </summary>
    None,
}
