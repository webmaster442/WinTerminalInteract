namespace Webmaster442.WindowsTerminalFragment;

[AttributeUsage(AttributeTargets.Field)]
internal class SerializedValueAttribute : Attribute
{
    public string SerializedValue { get; }

    public SerializedValueAttribute(string serializedValue)
    {
        SerializedValue = serializedValue;
    }
}
