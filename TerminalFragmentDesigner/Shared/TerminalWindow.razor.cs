using Microsoft.AspNetCore.Components;

using Webmaster442.WindowsTerminalFragment;

namespace TerminalFragmentDesigner.Shared
{
    public partial class TerminalWindow
    {

        [Parameter]
        [EditorRequired]
        public Profile Profile { get; set; }

        [Parameter]
        [EditorRequired]
        public Theme Theme { get; set; }
    }
}