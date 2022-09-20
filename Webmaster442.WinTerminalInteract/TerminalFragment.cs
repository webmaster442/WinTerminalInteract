namespace Webmaster442.WinTerminalInteract;

/// <summary>
/// JSON fragment extensions are snippets of JSON that application developers can write to add new profiles to users' settings, or even modify certain existing profiles. They can also be used to add new color schemes to users' settings.
/// </summary>
public sealed class TerminalFragment
{
    public TerminalFragment()
    {
        Profiles = new List<Profile>();
        Themes = new List<Theme>();
    }

    public List<Profile> Profiles { get; }
    public List<Theme> Themes { get; }
}
