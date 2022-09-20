using System.Text.Json;
using System.Text.Json.Serialization;

namespace Webmaster442.WindowsTerminalFragment.Internals;
internal class JsonGuidStringConverter : JsonConverter<Guid>
{
    public override Guid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var input = reader.GetString();

        if (string.IsNullOrEmpty(input))
            return Guid.Empty;

        return Guid.Parse(input);
    }

    public override void Write(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options)
    {
        string result = "{" + value.ToString() + "}";
        writer.WriteStringValue(result);
    }
}
