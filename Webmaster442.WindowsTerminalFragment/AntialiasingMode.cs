﻿namespace Webmaster442.WindowsTerminalFragment;

/// <summary>
/// This controls how text is antialiased in the renderer. Note that changing this setting will require starting a new terminal instance.
/// </summary>
public enum AntialiasingMode
{
    /// <summary>
    /// Grayscale
    /// </summary>
    Grayscale,
    /// <summary>
    /// Cleartype
    /// </summary>
    Cleartype,
    /// <summary>
    /// Aliased
    /// </summary>
    Aliased
}
