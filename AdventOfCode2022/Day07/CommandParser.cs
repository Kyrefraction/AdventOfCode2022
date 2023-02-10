using AdventOfCode2022.Day07.Models.Commands;

namespace AdventOfCode2022.Day07;

public static class CommandParser
{
    private const string CommandMarker = "$";
    private const string ChangeDirectoryCommand = "$ cd ";
    public static IEnumerable<ICommand> Parse(List<string> lines)
    {
        var commands = new List<ICommand>();
        for (var index = 0; index < lines.Count; index++)
        {
            if (IsChangeDirectoryCommand(lines[index]))
            {
                commands.Add(new ChangeDirectoryCommand(ParseChangeDirectoryCommandDirectory(lines[index])));
            }
            else
            {
                var listCommandResults = new List<string>();
                for (var listCommandResultIndex = index + 1; listCommandResultIndex < lines.Count; listCommandResultIndex++)
                {
                    if (lines[listCommandResultIndex].StartsWith(CommandMarker))
                    {
                        break;
                    }
                    
                    listCommandResults.Add(lines[listCommandResultIndex]);
                }

                commands.Add(new ListCommand(listCommandResults));
                index += listCommandResults.Count;
            }
        }

        return commands;
    }

    private static string ParseChangeDirectoryCommandDirectory(string line)
    {
        return line.Substring(ChangeDirectoryCommand.Length, line.Length - ChangeDirectoryCommand.Length);
    }

    private static bool IsChangeDirectoryCommand(string line)
    {
        return line.StartsWith(ChangeDirectoryCommand);
    }
}