using Microsoft.AspNetCore.Components;

using Webmaster442.WindowsTerminalFragment;

namespace TerminalFragmentDesigner.Shared
{
    public partial class TerminalWindow
    {

        [Parameter]
        public Profile Profile { get; set; }

        [Parameter]
        public Theme Theme { get; set; }
    }
}