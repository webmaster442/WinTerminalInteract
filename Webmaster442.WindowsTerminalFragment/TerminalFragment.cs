namespace Webmaster442.WindowsTerminalFragment;

/// <summary>
/// JSON fragment extensions are snippets of JSON that application developers can write to add new profiles to users' settings, or even modify certain existing profiles. They can also be used to add new color schemes to users' settings.
/// https://learn.microsoft.com/en-us/windows/terminal/json-fragment-extensions
/// https://learn.microsoft.com/en-us/windows/terminal/customize-settings/profile-general
/// </summary>
public sealed class TerminalFragment
{
    /// <summary>
    /// Creates a new instance of TerminalFragment
    /// </summary>
    public TerminalFragment()
    {
        Profiles = new List<Profile>();
        Themes = new List<Theme>();
    }

    /// <summary>
    /// Profiles contained in the fragment
    /// </summary>
    public List<Profile> Profiles { get; }

    /// <summary>
    /// Themes contained in the fragment
    /// </summary>
    public List<Theme> Themes { get; }
}
