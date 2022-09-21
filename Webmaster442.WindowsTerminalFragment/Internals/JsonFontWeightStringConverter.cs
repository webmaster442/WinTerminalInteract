using System.Text.Json;
using System.Text.Json.Serialization;

namespace Webmaster442.WindowsTerminalFragment.Internals;
internal class JsonFontWeightStringConverter : JsonConverter<FontWeight>
{
    private readonly Dictionary<FontWeight, string> _lookup;

    public JsonFontWeightStringConverter()
    {
        _lookup = SerializedValueTableFactrory.Create<FontWeight>();
    }

    public override FontWeight Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? input = reader.GetString();

        if (string.IsNullOrEmpty(input))
            return FontWeight.Normal;

        KeyValuePair<FontWeight, string> result = _lookup.FirstOrDefault(x => x.Value == input);

        return result.Key;

    }

    public override void Write(Utf8JsonWriter writer, FontWeight value, JsonSerializerOptions options)
    {
        string result = _lookup[value];
        writer.WriteStringValue(result);
    }
}
