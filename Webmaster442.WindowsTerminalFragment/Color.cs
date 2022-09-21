using System.Text;

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

    /// <summary>
    /// Converts the color to RGBA string
    /// </summary>
    /// <returns>an RGBA string</returns>
    public string ToRgbaString()
    {
        StringBuilder sb = new();
        sb.Append('#');
        sb.Append(Convert.ToString(R, 16).PadLeft(2, '0'));
        sb.Append(Convert.ToString(G, 16).PadLeft(2, '0'));
        sb.Append(Convert.ToString(B, 16).PadLeft(2, '0'));
        if (A != 255)
        {
            sb.Append(Convert.ToString(A, 16).PadLeft(2, '0'));
        }
        return sb.ToString();
    }
}
