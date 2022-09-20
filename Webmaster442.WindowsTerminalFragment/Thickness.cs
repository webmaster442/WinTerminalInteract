namespace Webmaster442.WindowsTerminalFragment;

/// <summary>
/// Represents Tichkness that is used to set the Padding
/// </summary>
public sealed record class Thickness
{
    /// <summary>
    /// Creates a new intance of thickness
    /// </summary>
    /// <param name="left">left value</param>
    /// <param name="top">top value</param>
    /// <param name="right">right value</param>
    /// <param name="bottom">bottom value</param>
    public Thickness(int left, int top, int right, int bottom)
    {
        Left = left;
        Top = top;
        Right = right;
        Bottom = bottom;
    }

    /// <summary>
    /// Creates a new intance of thickness
    /// </summary>
    /// <param name="uniform">Uniform value, that will be set to all properties</param>
    public Thickness(int uniform)
    {
        Left = uniform;
        Top = uniform;
        Right = uniform;
        Bottom = uniform;
    }

    /// <summary>
    /// Creates a new intance of thickness
    /// </summary>
    /// <param name="horizontal">Left and Right value</param>
    /// <param name="vertical">Top and Bottom value</param>
    public Thickness(int horizontal, int vertical)
    {
        Left = horizontal;
        Right = horizontal;
        Top = vertical;
        Bottom = vertical;
    }

    /// <summary>
    /// Gets the Left value
    /// </summary>
    public int Left { get; }

    /// <summary>
    /// Gets the Top value
    /// </summary>
    public int Top { get; }

    /// <summary>
    /// Gets the Right value
    /// </summary>
    public int Right { get; }

    /// <summary>
    /// Gets the Bottom value
    /// </summary>
    public int Bottom { get; }
}
