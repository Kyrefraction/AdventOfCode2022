namespace AdventOfCode2022.Utilities;

public static class StringExtensions
{
    public static string RemoveWhitespace(this string input)
    {
        return input.Replace(" ", string.Empty);
    }
}