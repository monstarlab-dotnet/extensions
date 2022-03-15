namespace Monstarlab.Extensions;

public static class StringExtensions
{
    /// <summary>
    /// Parse string to enum. Returns null if translation is not possible
    /// </summary>
    /// <typeparam name="T">Specific enum type</typeparam>
    /// <param name="value">The string value to parse</param>
    public static T? ToNullableEnum<T>(this string value) where T : struct, Enum
    {
        if (Enum.TryParse(typeof(T), value, out var result) && result != null)
        {
            return (T)result;
        }

        return null;
    }

    /// <summary>
    /// Parse string to enum. Returns <paramref name="defaultValue"/> if translation is not possible
    /// </summary>
    /// <typeparam name="T">Specific enum type</typeparam>
    /// <param name="value">The string value to parse</param>
    /// <param name="defaultValue">The default value if parsing is not possible</param>
    /// <returns></returns>
    public static T ToEnum<T>(this string value, T defaultValue) where T : struct, Enum
    {
        if (Enum.TryParse(typeof(T), value, out var result) && result != null)
        {
            return (T)result;
        }

        return defaultValue;
    }
}
