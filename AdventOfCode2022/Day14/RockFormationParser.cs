using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day14;

public static class RockFormationParser
{
    public static List<List<(int x, int y)>> Parse(IEnumerable<string> input)
    {
        return input.Select(ParseFormation).ToList();
    }

    private static List<(int, int)> ParseFormation(string formation)
    {
        return formation.Split("->")
            .Select(line => line.RemoveWhitespace().Split(","))
            .Select(coordinates => (coordinates.First().ToInt(), coordinates.Last().ToInt())).ToList();
    }
}