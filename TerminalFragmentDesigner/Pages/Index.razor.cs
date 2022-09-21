using Webmaster442.WindowsTerminalFragment;

namespace TerminalFragmentDesigner.Pages
{
    public partial class Index
    {
        public Profile Profile { get; set; }
        public Theme Theme { get; set; }

        public Index()
        {
            Profile = new Profile();
            Theme = new Theme("Default");
        }

    }
}