using System.Text.RegularExpressions;

namespace AdventOfCode2022.Utilities.Extensions;

public static class StringExtensions
{
    public static string RemoveWhitespace(this string input)
    {
        return input.Replace(" ", string.Empty);
    }
    
    public static string[] SpliceText(this string text, int lineLength) {
        return Regex.Matches(text, ".{1," + lineLength + "}").Select(m => m.Value).ToArray();
    }
}