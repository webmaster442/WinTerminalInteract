using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Webmaster442.WindowsTerminalFragment.Internals;
internal class JsonColorStringConverter : JsonConverter<Color>
{
    public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string input = reader.GetString() ?? "#000000";
        return Color.FromString(input);
    }

    public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
    {
        StringBuilder sb = new();
        sb.Append('#');
        sb.Append(Convert.ToString(value.R, 16).PadLeft(2, '0'));
        sb.Append(Convert.ToString(value.G, 16).PadLeft(2, '0'));
        sb.Append(Convert.ToString(value.B, 16).PadLeft(2, '0'));
        if (value.A != 255)
        {
            sb.Append(Convert.ToString(value.A, 16).PadLeft(2, '0'));
        }
        writer.WriteStringValue(sb.ToString());
    }
}
