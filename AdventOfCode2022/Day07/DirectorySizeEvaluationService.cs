using AdventOfCode2022.Day07.Models;
using AdventOfCode2022.Utilities;
using File = AdventOfCode2022.Day07.Models.File;

namespace AdventOfCode2022.Day07;

public class DirectorySizeEvaluationService
{
    private const int MaximumDirectorySize = 100000;
    private const int TotalSize = 70000000;
    private const int RequiredSize = 30000000;
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

    public int FindSmallestDirectoryOfRequiredSize()
    {
        var usedSize = GetUsedSize();
        var unusedSize = TotalSize - usedSize;
        var requiredSize = RequiredSize - unusedSize;

        var directoriesAboveRequiredSize = GetDirectorySizes(_fileSystem)
            .Where(directorySize => directorySize > requiredSize)
            .OrderBy(x => x);
        return directoriesAboveRequiredSize.First();
    }

    private int GetUsedSize()
    {
        return _fileSystem.Select(directory => directory.Value.Sum(file => file.Size)).Sum();
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