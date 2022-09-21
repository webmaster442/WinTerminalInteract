namespace Webmaster442.WindowsTerminalFragment.Internals;

internal static class ColorParser
{
    //"#rgb, "#rrggbb, "#rrggbbaa
    internal static Color Parse(string input)
    {
        if (string.IsNullOrEmpty(input))
            throw new ArgumentNullException(nameof(input), "must not be null or empty");

        if (!input.StartsWith("#"))
            throw new ArgumentException($"{nameof(input)} must start with #");

        int digitCount = GetDigits(input);

        return digitCount switch
        {
            3 => Parse3Hex(input),
            6 => Parse6Hex(input),
            8 => Parse8Hex(input),
            _ => throw new ArgumentException($"{nameof(input)} must contain 3 or 6 or 8 hex chars"),
        };
    }

    private static Color Parse8Hex(string input)
    {
        return new Color(
            r: (byte)Convert.ToInt32(input.Substring(1, 2), 16),
            g: (byte)Convert.ToInt32(input.Substring(3, 2), 16),
            b: (byte)Convert.ToInt32(input.Substring(5, 2), 16),
            a: (byte)Convert.ToInt32(input.Substring(7, 2), 16));
    }

    private static Color Parse6Hex(string input)
    {
        return new Color(
            r: (byte)Convert.ToInt32(input.Substring(1, 2), 16),
            g: (byte)Convert.ToInt32(input.Substring(3, 2), 16),
            b: (byte)Convert.ToInt32(input.Substring(5, 2), 16));


    }

    private static Color Parse3Hex(string input)
    {
        return Parse6Hex($"#{input[1]}{input[1]}{input[2]}{input[2]}{input[3]}{input[3]}");
    }

    private static int GetDigits(string input)
    {
        int hashMark = 0;
        int digits = 0;
        foreach (char c in input)
        {
            if (c == '#')
            {
                hashMark++;
                continue;
            }

            if (IsHexChar(c))
            {
                digits++;
            }
        }

        if (hashMark > 1)
        {
            throw new ArgumentException("input must only contain one #");
        }

        return digits;
    }

    private static bool IsHexChar(char c)
    {
        return char.IsDigit(c)
            || c switch
            {
                'A' or 'a' or 'B' or 'b' or 'C' or 'c' or 'D' or 'd' or 'E' or 'e' or 'F' or 'f' => true,
                _ => throw new ArgumentException("Input contains non hexadecimal chars"),
            };
    }
}