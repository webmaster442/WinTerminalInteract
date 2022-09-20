using System.Text.Json;
using System.Text.Json.Serialization;

namespace Webmaster442.WindowsTerminalFragment.Internals;
internal static class SerializerOptionFactory
{
    public static JsonSerializerOptions Create()
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            NumberHandling = JsonNumberHandling.WriteAsString,
        };
        options.Converters.Add(new JsonStringEnumConverter());
        options.Converters.Add(new JsonColorStringConverter());
        options.Converters.Add(new JsonThicknessStringConverter());
        options.Converters.Add(new JsonGuidStringConverter());
        return options;
    }
}
