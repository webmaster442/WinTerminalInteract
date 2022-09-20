using Webmaster442.WindowsTerminalFragment.Internals;

namespace Webmaster442.WindowsTerminalFragment;
public record struct Color
{
    public Color(byte r, byte g, byte b, byte a)
    {
        R = r;
        G = g;
        B = b;
        A = a;
    }

    public Color(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
        A = 255;
    }

    public Color()
    {
        R = 0;
        G = 0;
        B = 0;
        A = 255;
    }

    public static Color FromString(string input)
    {
        return ColorParser.Parse(input);
    }

    public byte R { get; }
    public byte G { get; }
    public byte B { get; }
    public byte A { get; }
}
