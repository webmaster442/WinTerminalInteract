namespace Webmaster442.WinTerminalInteract;
public sealed class Theme
{
    /// <summary>
    /// This is the name of the theme. Names should be unique. The names dark, light, and system are reserved for the built-in default themes.
    /// </summary>
    public Color Name { get; set; }

    /// <summary>
    /// This sets the UI theme of the application. This will stylize items such as buttons, the command palette, and other application UI elements. It can either be light or dark. "system" will use the same theme as Windows.
    /// </summary>
    public ApplicationTheme ApplicationTheme { get; set; }

    public Color Background { get; set; }
    public Color Black { get; set; }
    public Color Blue { get; set; }
    public Color BrightBlack { get; set; }
    public Color BrightBlue { get; set; }
    public Color BrightCyan { get; set; }
    public Color BrightGreen { get; set; }
    public Color BrightPurple { get; set; }
    public Color BrightRed { get; set; }
    public Color BrightWhite { get; set; }
    public Color BrightYellow { get; set; }
    public Color CursorColor { get; set; }
    public Color Cyan { get; set; }
    public Color Foreground { get; set; }
    public Color Green { get; set; }
    public Color Purple { get; set; }
    public Color Red { get; set; }
    public Color SelectionBackground { get; set; }
    public Color White { get; set; }
    public Color Yellow { get; set; }

    public Theme(Color name)
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
