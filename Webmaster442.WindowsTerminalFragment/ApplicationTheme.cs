﻿namespace Webmaster442.WindowsTerminalFragment;

/// <summary>
/// This sets the UI theme of the application. This will stylize items such as buttons, the command palette, and other application UI elements. It can either be light or dark. "system" will use the same theme as Windows.
/// </summary>
public enum ApplicationTheme
{
    /// <summary>
    /// use the same theme as Windows
    /// </summary>
    System,
    /// <summary>
    /// use Dark theme
    /// </summary>
    Dark,
    /// <summary>
    /// use Light theme
    /// </summary>
    Light,
}
