using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day11.Parsers;

public static class MonkeyTestParser
{
    private const string TestMarker = "Test: divisible by ";
    public static int Parse(string testInformation)
    {
        var startIndex = testInformation.IndexOf(TestMarker, StringComparison.Ordinal) + TestMarker.Length;
        return testInformation[startIndex..].ToInt();
    }
}