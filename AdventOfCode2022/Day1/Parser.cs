namespace AdventOfCode2022.Day1;

public static class Parser
{
    private static readonly string Separator = Environment.NewLine;

    public static IEnumerable<IEnumerable<int>> Parse(IEnumerable<string> integerGroups)
    {
        return integerGroups.Select(ParseIntegerGroup);
    }

    private static IEnumerable<int> ParseIntegerGroup(string integerGroup)
    {
        return integerGroup.Split(Separator).Select(int.Parse);
    }
}