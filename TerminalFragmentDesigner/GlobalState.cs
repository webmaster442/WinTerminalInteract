using Webmaster442.WindowsTerminalFragment;

namespace TerminalFragmentDesigner;

public class GlobalState
{
    public GlobalState()
    {
        CurrentFragment = new TerminalFragment();
        CurrentFragment.Profiles.Add(new Profile());
        CurrentFragment.Themes.Add(new Theme("Edited Theme"));
    }

    public TerminalFragment CurrentFragment
    {
        get;
    }
}
