namespace Webmaster442.WindowsTerminalFragment;

public class Font
{
    /// <summary>
    /// This is the name of the font face used in the profile. The terminal will try to fallback to Consolas if this can't be found or is invalid. To learn about the other variants of the default font, Cascadia Mono, visit the Cascadia Code page.
    /// </summary>
    public string Face { get; set; }

    /// <summary>
    /// This sets the profile's font size in points.
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// This sets the weight (lightness or heaviness of the strokes) for the profile's font.
    /// </summary>
    public FontWeight Weight { get; set; }

    public Font()
    {
        Face = "Cascadia Mono";
        Size = 12;
        Weight = FontWeight.Normal;
    }
}
