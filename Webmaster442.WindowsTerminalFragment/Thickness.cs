namespace Webmaster442.WindowsTerminalFragment;

public sealed record class Thickness
{
    public Thickness(int left, int top, int right, int bottom)
    {
        Left = left;
        Top = top;
        Right = right;
        Bottom = bottom;
    }

    public Thickness(int uniform)
    {
        Left = uniform;
        Top = uniform;
        Right = uniform;
        Bottom = uniform;
    }

    public Thickness(int horizontal, int vertical)
    {
        Left = horizontal;
        Right = horizontal;
        Top = vertical;
        Bottom = vertical;
    }

    public int Left { get; }
    public int Top { get; }
    public int Right { get; }
    public int Bottom { get; }
}
