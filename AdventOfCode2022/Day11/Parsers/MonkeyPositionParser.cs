using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day11.Parsers;

public static class MonkeyPositionParser
{
    private const string PositionMarker = "Monkey";
    private const string EndMarker = ":";
    public static int Parse(string positionInformation)
    {
        return positionInformation.GetStringBetween(PositionMarker, EndMarker).ToInt();
    }
}