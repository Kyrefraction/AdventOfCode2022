using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day11.Parsers;

public static class MonkeyDestinationParser
{
    public static int Parse(string destinationInformation)
    {
        return destinationInformation[^1..].ToInt();
    }
}