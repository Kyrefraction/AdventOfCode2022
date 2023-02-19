using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day11.Parsers;

public static class MonkeyStartingItemsParser
{
    private const string StartingItemsMarker = "Starting items:";
    public static List<long> Parse(string startingItemsInformation)
    {
        var startIndex = startingItemsInformation.IndexOf(StartingItemsMarker, StringComparison.Ordinal) + StartingItemsMarker.Length;
        var itemsString = startingItemsInformation.Substring(startIndex, startingItemsInformation.Length - startIndex);
        return itemsString
            .RemoveWhitespace()
            .Split(",")
            .Select(item => item.ToLong())
            .ToList();
    }
}