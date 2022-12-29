using AdventOfCode2022.Day7.Models;
using AdventOfCode2022.Utilities;
using File = AdventOfCode2022.Day7.Models.File;

namespace AdventOfCode2022.Day7;

public class DirectorySizeEvaluationService
{
    private const int MaximumDirectorySize = 100000;
    private readonly Dictionary<string, List<File>> _fileSystem;

    public DirectorySizeEvaluationService(string filePath)
    {
        var lines = FileReader.ExtractInput(filePath, Environment.NewLine);
        var commands = CommandParser.Parse(lines.ToList());
        _fileSystem = FileSystem.FromCommands(commands);
    }


    public int Evaluate()
    {
        return GetDirectorySizes(_fileSystem)
            .Where(directorySize => directorySize <= MaximumDirectorySize)
            .Sum();
    }

    private static IEnumerable<int> GetDirectorySizes(Dictionary<string, List<File>> fileSystem)
    {
        return fileSystem
            .Select(directory =>
                fileSystem.Keys.Where(key => key.StartsWith(directory.Key))
                    .Select(subDirectoryKey => fileSystem[subDirectoryKey])
                    .Select(subDirectory => subDirectory.Sum(file => file.Size))
                    .Sum()
            );
    }
}