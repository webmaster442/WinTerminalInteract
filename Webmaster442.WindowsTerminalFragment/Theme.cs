namespace Webmaster442.WindowsTerminalFragment;

/// <summary>
/// Represents Terminal theme
/// </summary>
public sealed class Theme
{
    /// <summary>
    /// This is the name of the theme. Names should be unique. The names dark, light, and system are reserved for the built-in default themes.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// This sets the UI theme of the application. This will stylize items such as buttons, the command palette, and other application UI elements. It can either be light or dark. "system" will use the same theme as Windows.
    /// </summary>
    public ApplicationTheme ApplicationTheme { get; set; }

    /// <summary>
    /// Background color
    /// </summary>
    public Color Background { get; set; }

    /// <summary>
    /// Black
    /// </summary>
    public Color Black { get; set; }

    /// <summary>
    /// Blue
    /// </summary>
    public Color Blue { get; set; }

    /// <summary>
    /// BrightBlack
    /// </summary>
    public Color BrightBlack { get; set; }

    /// <summary>
    /// BrightBlue
    /// </summary>
    public Color BrightBlue { get; set; }

    /// <summary>
    /// BrightCyan
    /// </summary>
    public Color BrightCyan { get; set; }

    /// <summary>
    /// BrightGreen
    /// </summary>
    public Color BrightGreen { get; set; }

    /// <summary>
    /// BrightPurple
    /// </summary>
    public Color BrightPurple { get; set; }

    /// <summary>
    /// BrightRed
    /// </summary>
    public Color BrightRed { get; set; }

    /// <summary>
    /// BrightWhite
    /// </summary>
    public Color BrightWhite { get; set; }

    /// <summary>
    /// BrightYellow
    /// </summary>
    public Color BrightYellow { get; set; }

    /// <summary>
    /// Cursor color
    /// </summary>
    public Color CursorColor { get; set; }

    /// <summary>
    /// Cyan
    /// </summary>
    public Color Cyan { get; set; }

    /// <summary>
    /// Foreground
    /// </summary>
    public Color Foreground { get; set; }

    /// <summary>
    /// Green
    /// </summary>
    public Color Green { get; set; }

    /// <summary>
    /// Purple
    /// </summary>
    public Color Purple { get; set; }

    /// <summary>
    /// Red
    /// </summary>
    public Color Red { get; set; }

    /// <summary>
    /// Selection background
    /// </summary>
    public Color SelectionBackground { get; set; }

    /// <summary>
    /// White
    /// </summary>
    public Color White { get; set; }

    /// <summary>
    /// Yellow
    /// </summary>
    public Color Yellow { get; set; }

    /// <summary>
    /// Creates a new instance of theme
    /// </summary>
    /// <param name="name">theme name</param>
    public Theme(string name)
    {
        Name = name;
        ApplicationTheme = ApplicationTheme.Dark;
        Background = Color.FromString("#0C0C0C");
        Black = Color.FromString("#0C0C0C");
        Blue = Color.FromString("#0037DA");
        BrightBlack = Color.FromString("#767676");
        BrightBlue = Color.FromString("#3B78FF");
        BrightCyan = Color.FromString("#61D6D6");
        BrightGreen = Color.FromString("#16C60C");
        BrightPurple = Color.FromString("#B4009E");
        BrightRed = Color.FromString("#E74856");
        BrightWhite = Color.FromString("#F2F2F2");
        BrightYellow = Color.FromString("#F9F1A5");
        CursorColor = Color.FromString("#FFFFFF");
        Cyan = Color.FromString("#3A96DD");
        Foreground = Color.FromString("#CCCCCC");
        Green = Color.FromString("#13A10E");
        Purple = Color.FromString("#881798");
        Red = Color.FromString("#C50F1F");
        SelectionBackground = Color.FromString("#FFFFFF");
        White = Color.FromString("#CCCCCC");
        Yellow = Color.FromString("#C19C00");
    }
}
