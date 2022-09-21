using System.Reflection;

namespace Webmaster442.WindowsTerminalFragment.Internals;

internal static class SerializedValueTableFactrory
{
    internal static Dictionary<T, string> Create<T>() where T : struct, Enum
    {
        Type enumType = typeof(T);

        T[] values = Enum.GetValues<T>();
        Dictionary<T, string> result = new Dictionary<T, string>(values.Length);
        foreach (T value in values)
        {
            string? name = Enum.GetName<T>(value);
            if (!string.IsNullOrEmpty(name))
            {
                MemberInfo[] possibleMembers = enumType.GetMember(name);
                MemberInfo? member = possibleMembers.FirstOrDefault(m => m.DeclaringType == enumType);

                SerializedValueAttribute? serializedValueAttribute = member?.GetCustomAttribute<SerializedValueAttribute>();
                if (serializedValueAttribute == null)
                {
                    result.Add(value, name);
                }
                else
                {
                    result.Add(value, serializedValueAttribute.SerializedValue);
                }
            }
        }
        return result;
    }
}