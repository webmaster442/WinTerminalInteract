using Webmaster442.WindowsTerminalFragment.Internals;

namespace Webmaster442.WindowsTerminalFragment;

/// <summary>
/// Represents a color
/// </summary>
public record struct Color
{
    /// <summary>
    /// Creates a new instance of color
    /// </summary>
    /// <param name="r">red value</param>
    /// <param name="g">green value</param>
    /// <param name="b">blue value</param>
    /// <param name="a">alpha value</param>
    public Color(byte r, byte g, byte b, byte a)
    {
        R = r;
        G = g;
        B = b;
        A = a;
    }

    /// <summary>
    /// Creates a new instance of color
    /// </summary>
    /// <param name="r">red value</param>
    /// <param name="g">green value</param>
    /// <param name="b">blue value</param>
    public Color(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
        A = 255;
    }

    /// <summary>
    /// Creates a new instance of color with default (black) value
    /// </summary>
    public Color()
    {
        R = 0;
        G = 0;
        B = 0;
        A = 255;
    }

    /// <summary>
    /// Creates a color from a hex string
    /// Accepted formats: #rgb, #rrggbb and #rrggbbaa
    /// </summary>
    /// <param name="input">input string in one of the following formats: #rgb, #rrggbb and #rrggbbaa</param>
    /// <returns>A color</returns>
    public static Color FromString(string input)
    {
        return ColorParser.Parse(input);
    }

    /// <summary>
    /// Red value
    /// </summary>
    public byte R { get; }

    /// <summary>
    /// Green value
    /// </summary>
    public byte G { get; }

    /// <summary>
    /// Blue value
    /// </summary>
    public byte B { get; }

    /// <summary>
    /// Alpha value
    /// </summary>
    public byte A { get; }
}
