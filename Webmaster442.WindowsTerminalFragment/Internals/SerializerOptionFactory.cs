using System.Text.Json;
using System.Text.Json.Serialization;

namespace Webmaster442.WindowsTerminalFragment.Internals;
internal static class SerializerOptionProvider
{
    public static readonly JsonSerializerOptions SerializerOptions = new()
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        NumberHandling = JsonNumberHandling.WriteAsString,
        Converters =
        {
            new JsonFontWeightStringConverter(),
            new JsonStringEnumConverter(),
            new JsonColorStringConverter(),
            new JsonThicknessStringConverter(),
            new JsonGuidStringConverter(),
        }
    };
}
