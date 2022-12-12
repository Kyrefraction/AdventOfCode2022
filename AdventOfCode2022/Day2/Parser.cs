namespace AdventOfCode2022.Day2;

public static class Parser
{
    private const string Separator = " ";

    public static IEnumerable<(string, string)> Parse(IEnumerable<string> input)
    {
        return input.Select(ParseRound);
    }

    private static (string, string) ParseRound(string round)
    {
        var moves = round.Split(Separator);
        return (moves[0], moves[1]);
    }
}