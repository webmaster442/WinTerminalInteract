using System.Text.Json;

using Webmaster442.WindowsTerminalFragment.Internals;

namespace Webmaster442.WindowsTerminalFragment;
internal static class TerminalFragmentFile
{
    public static void Write(string targetFile, TerminalFragment terminalFragment)
    {
        string json = JsonSerializer.Serialize(terminalFragment, SerializerOptionFactory.Create());
        File.WriteAllText(targetFile, json);
    }

    public static async Task WriteAsync(string targetFile, TerminalFragment terminalFragment, CancellationToken cancellationToken = default)
    {
        string json = JsonSerializer.Serialize(terminalFragment, SerializerOptionFactory.Create());
        await File.WriteAllTextAsync(targetFile, json, cancellationToken);
    }

    public static TerminalFragment Read(string sourceFile)
    {
        string json = File.ReadAllText(sourceFile);
        TerminalFragment? result = JsonSerializer.Deserialize<TerminalFragment>(json, SerializerOptionFactory.Create());

        if (result == null)
            throw new InvalidOperationException("invalid terminal fragment document");

        return result;
    }

    public static async Task<TerminalFragment> ReadAsync(string sourceFile, CancellationToken cancellationToken = default)
    {
        string json = await File.ReadAllTextAsync(sourceFile, cancellationToken);
        TerminalFragment? result = JsonSerializer.Deserialize<TerminalFragment>(json, SerializerOptionFactory.Create());

        if (result == null)
            throw new InvalidOperationException("invalid terminal fragment document");

        return result;
    }
}
