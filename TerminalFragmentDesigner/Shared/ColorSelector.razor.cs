using Microsoft.AspNetCore.Components;

using Webmaster442.WindowsTerminalFragment;

namespace TerminalFragmentDesigner.Shared
{
    public partial class ColorSelector
    {
        [Parameter]
        [EditorRequired]
        public Color InColor { get; set; }

        [Parameter]
        [EditorRequired]
        public string Label { get; set; }

        [Parameter]
        public EventCallback<Color> ReturnedColor { get; set; }

        private void UpdateIt(ChangeEventArgs e)
        {
            string? str = e.Value?.ToString();
            if (!string.IsNullOrEmpty(str))
            {
                InColor = Color.FromString(str);
                ReturnedColor.InvokeAsync(InColor);
                StateHasChanged();
            }
        }
    }
}