using System.Text.RegularExpressions;

namespace AdventOfCode2022.Utilities.Extensions;

public static class StringExtensions
{
    public static string RemoveWhitespace(this string input)
    {
        return input.Replace(" ", string.Empty);
    }
    
    public static string[] SpliceText(this string input, int lineLength) {
        return Regex.Matches(input, ".{1," + lineLength + "}").Select(m => m.Value).ToArray();
    }

    public static string GetStringBetween(this string input, string start, string end)
    {
        var startIndex = input.IndexOf(start, StringComparison.Ordinal) + start.Length;
        var endIndex = input.LastIndexOf(end, StringComparison.Ordinal);
        var length = endIndex - startIndex;
        
        return input.Substring(startIndex, length);
    }

    public static int ToInt(this string input)
    {
        return int.Parse(input);
    }

    public static long ToLong(this string input)
    {
        return long.Parse(input);
    }
}