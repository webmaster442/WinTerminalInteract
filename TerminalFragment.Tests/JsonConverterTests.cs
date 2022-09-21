using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TerminalFragment.Tests;

[TestFixture]
internal class JsonConverterTests
{
    public static readonly JsonSerializerOptions TestOptions = new()
    {
        WriteIndented = false,
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

    public record class TestObject
    {
        public Color Color { get; set; }
        public FontWeight FontWeight { get; set; }
        public Thickness? Thickness { get; set; }
        public Guid Guid { get; set; }
    }

    [Test]
    public void TestSerialize()
    {
        TestObject @object = new TestObject
        {
            Color = new Color(0, 255, 0, 9),
            FontWeight = FontWeight.SemiBold,
            Guid = Guid.Parse("{C5763F82-38AB-4F18-8FE4-CB01ED0DD162}"),
            Thickness = new Thickness(1, 2, 3, 4),
        };

        var actual = JsonSerializer.Serialize(@object, TestOptions);
        var expected = "{\"color\":\"#00ff0009\",\"fontWeight\":\"semi-bold\",\"thickness\":\"1, 2, 3, 4\",\"guid\":\"{c5763f82-38ab-4f18-8fe4-cb01ed0dd162}\"}";

        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void TestDeserialize1()
    {
        const string input = "{\"color\":\"#00ff00\",\"fontWeight\":\"semi-bold\",\"thickness\":\"1, 2, 3, 4\",\"guid\":\"{c5763f82-38ab-4f18-8fe4-cb01ed0dd162}\"}";

        TestObject expected = new TestObject
        {
            Color = new Color(0, 255, 0),
            FontWeight = FontWeight.SemiBold,
            Guid = Guid.Parse("{C5763F82-38AB-4F18-8FE4-CB01ED0DD162}"),
            Thickness = new Thickness(1, 2, 3, 4),
        };

        var actual = JsonSerializer.Deserialize<TestObject>(input, TestOptions);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestDeserialize2()
    {
        const string input = "{\"color\":\"#00ff00\",\"fontWeight\":\"semi-bold\",\"thickness\":\"1\",\"guid\":\"{c5763f82-38ab-4f18-8fe4-cb01ed0dd162}\"}";

        TestObject expected = new TestObject
        {
            Color = new Color(0, 255, 0),
            FontWeight = FontWeight.SemiBold,
            Guid = Guid.Parse("{C5763F82-38AB-4F18-8FE4-CB01ED0DD162}"),
            Thickness = new Thickness(1),
        };

        var actual = JsonSerializer.Deserialize<TestObject>(input, TestOptions);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestDeserialize3()
    {
        const string input = "{\"color\":\"#00ff00\",\"fontWeight\":\"semi-bold\",\"thickness\":\"1, 2\",\"guid\":\"{c5763f82-38ab-4f18-8fe4-cb01ed0dd162}\"}";

        TestObject expected = new TestObject
        {
            Color = new Color(0, 255, 0),
            FontWeight = FontWeight.SemiBold,
            Guid = Guid.Parse("{C5763F82-38AB-4F18-8FE4-CB01ED0DD162}"),
            Thickness = new Thickness(1, 2),
        };

        var actual = JsonSerializer.Deserialize<TestObject>(input, TestOptions);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
