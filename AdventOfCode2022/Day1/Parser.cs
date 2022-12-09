namespace AdventOfCode2022.Day1;

public static class Parser
{
    private static readonly string Splitter = Environment.NewLine;

    public static IEnumerable<IEnumerable<int>> Parse(IEnumerable<string> integerGroups)
    {
        return integerGroups.Select(ParseIntegerGroup);
    }

    private static IEnumerable<int> ParseIntegerGroup(string integerGroup)
    {
        return integerGroup.Split(Splitter).Select(int.Parse);
    }
}