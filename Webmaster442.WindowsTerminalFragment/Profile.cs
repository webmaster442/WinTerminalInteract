﻿namespace Webmaster442.WindowsTerminalFragment;

/// <summary>
/// Represents the Terminal Profile settings
/// </summary>
public sealed class Profile
{
    private bool _useAcrylic;

    /// <summary>
    /// Profiles can use a GUID as a unique identifier. To make a profile your default profile, it needs a GUID for the defaultProfile global setting.
    /// </summary>
    public Guid Guid { get; set; }

    /// <summary>
    /// When this is set to true, tabTitle overrides the default title of the tab and any title change messages from the application will be suppressed. If tabTitle isn't set, name will be used instead. When this is set to false, tabTitle behaves as normal.
    /// </summary>
    public bool SuppressApplicationTitle { get; set; }

    /// <summary>
    /// This is the name of the profile that will be displayed in the dropdown menu. This value is also used as the "title" to pass to the shell on startup. Some shells (like bash) may choose to ignore this initial value, while others (Command Prompt, PowerShell) may use this value over the lifetime of the application. This "title" behavior can be overridden by using tabTitle.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// This is the executable used in the profile.
    /// </summary>
    public string Commandline { get; set; }

    /// <summary>
    /// This sets the icon that displays within the tab, dropdown menu, jumplist, and tab switcher. File location as a string, or an emoji
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// This is the name of the color scheme used in the profile. Color schemes are defined in the schemes object. More detailed information can be found on the Color schemes page.
    /// </summary>
    public string ColorScheme { get; set; }

    /// <summary>
    /// This controls how text is antialiased in the renderer. Note that changing this setting will require starting a new terminal instance.
    /// </summary>
    public AntialiasingMode AntialiasingMode { get; set; }

    /// <summary>
    /// This sets how the profile reacts to termination or failure to launch. "graceful" will close the profile when exit is typed or when the process exits normally. "always" will always close the profile and "never" will never close the profile. true and false are accepted as synonyms for "graceful" and "never", respectively.
    /// </summary>
    public CloseOnExit CloseOnExit { get; set; }

    /// <summary>
    /// Controls what happens when the application emits a BEL character. When set to "all", the terminal will play a sound and flash the taskbar icon. When the terminal is not in focus, only the taskbar icon will flash.
    /// </summary>
    public BellStyle BellStyle { get; set; }

    /// <summary>
    /// This sets the cursor shape for the profile. The possible cursors are as follows: "bar" ( ┃ ), "vintage" ( ▃ ), "underscore" ( ▁ ), "filledBox" ( █ ), "emptyBox" ( ▯ ), "doubleUnderscore" ( ‗ )
    /// </summary>
    public CursorShape CursorShape { get; set; }

    /// <summary>
    /// This is the structure within which the other font settings must be defined.
    /// </summary>
    public Font Font { get; set; }

    /// <summary>
    /// If hidden is set to true, the profile will not appear in the list of profiles. This can be used to hide default profiles and dynamically generated profiles, while leaving them in your settings file. To learn more about dynamic profiles, visit the Dynamic profiles page.
    /// </summary>
    public bool Hidden { get; set; }

    /// <summary>
    /// This sets the number of lines above the ones displayed in the window you can scroll back to.
    /// </summary>
    public int HistorySize { get; set; }

    /// <summary>
    /// his sets the padding around the text within the window. This will accept three different formats: "#" and # set the same padding for all sides, "#, #" sets the same padding for left-right and top-bottom, and "#, #, #, #" sets the padding individually for left, top, right, and bottom.
    /// </summary>
    public Thickness Padding { get; set; }

    /// <summary>
    /// When this is set to true, the window will scroll to the command input line when typing. When it's set to false, the window will not scroll when you start typing.
    /// </summary>
    public bool SnapOnInput { get; set; }

    /// <summary>
    /// This allows you to control if Windows Terminal will treat ctrl+alt as an alias for AltGr.
    /// </summary>
    public bool AltGrAliasing { get; set; }

    /// <summary>
    /// If set, this profile will automatically open up in an "elevated" window (running as Administrator) by default. If you run this profile from an unelevated window, then a new elevated terminal window will be created to host this profile. If you launch this profile from an already elevated window, then it will open as a new tab.
    /// When this property is set to false, opening this profile in an elevated window will not launch an unelevated window to host this profile. The profile will simply open in the elevated window, running as Administrator.
    /// If you set this property in profiles.defaults, then all profiles will launch as Administrator by default, unless overridden by specifically setting this to false.
    /// </summary>
    public bool Elevate { get; set; }

    /// <summary>
    /// If set, this will replace the name as the title to pass to the shell on startup. Some shells (like bash) may choose to ignore this initial value, while others (Command Prompt, PowerShell) may use this value over the lifetime of the application. If you'd like to learn how to have the shell set your title, visit the tab title tutorial.
    /// </summary>
    public string TabTitle { get; set; }

    /// <summary>
    /// This is the directory the shell starts in when it is loaded.
    /// </summary>
    public string StartingDirectory { get; set; }

    /// <summary>
    /// When this is set to true, the window will have an acrylic background. When it's set to false, the window will have a plain, untextured background. The transparency only applies to focused windows due to OS limitations.
    /// </summary>
    public bool UseAcrylic
    {
        get => _useAcrylic;
        set
        {
            _useAcrylic = value;
            Opacity = value ? 50 : 100;
        }
    }

    /// <summary>
    /// This sets the file location of the image to draw over the window background. The background image can be a .jpg, .png, or .gif file. "desktopWallpaper" will set the background image to the desktop's wallpaper.
    /// </summary>
    public string? BackgroundImage { get; set; }

    /// <summary>
    /// This sets how the background image is resized to fill the window.
    /// </summary>
    public BackgroundImageStretchMode BackgroundImageStretchMode { get; set; }

    /// <summary>
    /// This sets how the background image aligns to the boundaries of the window.
    /// </summary>
    public BackgroundImageAlignment BackgroundImageAlignment { get; set; }

    /// <summary>
    /// This sets the transparency of the background image.
    /// </summary>
    public float BackgroundImageOpacity { get; set; }

    /// <summary>
    /// This sets the transparency of the window for the profile. This accepts an integer value from 0-100, representing a "percent opaque". 100 is "fully opaque", 50 is semi-transparent, and 0 is fully transparent.
    /// When useAcrylic is set to true, the window will use the acrylic material to create a blurred background for the terminal. When useAcrylic is set to false, the terminal will use a unblurred opacity.
    /// </summary>
    public int Opacity { get; set; }

    /// <summary>
    /// Creates a new instance of Profile
    /// </summary>
    public Profile()
    {
        Name = string.Empty;
        Commandline = string.Empty;
        StartingDirectory = "%USERPROFILE%";
        TabTitle = string.Empty;
        ColorScheme = "Campbell";
        Font = new Font();
        HistorySize = 9001;
        SnapOnInput = true;
        AltGrAliasing = true;
        CloseOnExit = CloseOnExit.Graceful;
        BellStyle = BellStyle.Audible;
        AntialiasingMode = AntialiasingMode.Grayscale;
        CursorShape = CursorShape.Bar;
        Padding = new Thickness(8);
        Guid = Guid.NewGuid();
        BackgroundImageStretchMode = BackgroundImageStretchMode.UniformToFill;
        BackgroundImageAlignment = BackgroundImageAlignment.Center;
        BackgroundImageOpacity = 1.0f;
        Opacity = 100;
    }
}
