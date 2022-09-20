using System.Text.Json;
using System.Text.Json.Serialization;

namespace Webmaster442.WindowsTerminalFragment.Internals;
internal class JsonThicknessStringConverter : JsonConverter<Thickness>
{
    public override Thickness? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? input = reader.GetString();

        if (string.IsNullOrEmpty(input))
            return null;

        string[] parts = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        return parts.Length switch
        {
            1 => new Thickness(int.Parse(parts[0])),
            2 => new Thickness(int.Parse(parts[0]), int.Parse(parts[1])),
            4 => new Thickness(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3])),
            _ => null,
        };
    }

    public override void Write(Utf8JsonWriter writer, Thickness value, JsonSerializerOptions options)
    {
        string result = $"{value.Left}, {value.Top}, {value.Right}, {value.Bottom}";
        writer.WriteStringValue(result);
    }
}
