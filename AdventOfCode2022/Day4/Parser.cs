namespace AdventOfCode2022.Day4;

public static class Parser
{
    private const string Separator = ",";
    public static (string, string) Parse(string input)
    {
        var ranges = input.Split(Separator);
        return (ranges[0], ranges[1]);
    }
}