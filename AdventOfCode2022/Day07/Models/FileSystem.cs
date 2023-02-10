using AdventOfCode2022.Day07.Models.Commands;

namespace AdventOfCode2022.Day07.Models;

public static class FileSystem
{
    private const string RootDirectory = "/";

    public static Dictionary<string, List<File>> FromCommands(IEnumerable<ICommand> commands)
    {
        var fileSystem = new Dictionary<string, List<File>> { { RootDirectory, new List<File>() } };
        var currentDirectory = RootDirectory;
        
        foreach (var command in commands)
        {
            switch (command)
            {
                case ChangeDirectoryCommand changeDirectoryCommand:
                    currentDirectory = changeDirectoryCommand.Execute(currentDirectory);
                    break;
                case ListCommand listCommand:
                    fileSystem = listCommand.Execute(currentDirectory, fileSystem);
                    break;
                default:
                    throw new Exception($"Attempted to execute command of unknown type {command}");
            }
        }
        
        return fileSystem;
    }
}