namespace Webmaster442.WinTerminalInteract;

/// <summary>
/// This defines whether the terminal will launch as maximized, full screen, or in a window. Setting this to focus is equivalent to launching the terminal in the default mode, but with focus mode enabled. Similarly, setting this to maximizedFocus will result in launching the terminal in a maximized window with focus mode enabled.
/// </summary>
public enum LaunchMode
{
    Default,
    Maximized,
    Fullscreen,
    Focus,
    MaximizedFocus
}
