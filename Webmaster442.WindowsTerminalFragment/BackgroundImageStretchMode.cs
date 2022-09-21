﻿namespace Webmaster442.WindowsTerminalFragment;

/// <summary>
/// This sets how the background image is resized to fill the window.
/// </summary>
public enum BackgroundImageStretchMode
{
    /// <summary>
    /// The content preserves its original size.
    /// </summary>
    None,
    /// <summary>
    /// The content is resized to fill the destination dimensions. The aspect ratio is not preserved.
    /// </summary>
    Fill,
    /// <summary>
    /// The content is resized to fit in the destination dimensions while it preserves its native aspect ratio.
    /// </summary>
    Uniform,
    /// <summary>
    /// The content is resized to fill the destination dimensions while it preserves its native aspect ratio. If the aspect ratio of the destination rectangle differs from the source, the source content is clipped to fit in the destination dimensions.
    /// </summary>
    UniformToFill
}
