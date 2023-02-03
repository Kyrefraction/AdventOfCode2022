using AdventOfCode2022.Day10.Commands;

namespace AdventOfCode2022.Day10;

public static class Parser
{
    private const int AddCommandPrefixLength = 5;
    private const string NoOpCommand = "noop";
    public static List<ICommand> Parse(IEnumerable<string> input)
    {
        var commands = new List<ICommand>();
        foreach (var line in input)
        {
            if (line == NoOpCommand)
            {
                commands.Add(new NoOpCommand());
            }
            else
            {
                commands.Add(new AddCommand(int.Parse(line.Substring(AddCommandPrefixLength, line.Length - AddCommandPrefixLength))));
            }
        }

        return commands;
    }
}