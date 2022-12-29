using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day7.Models.Commands;

public record ListCommand(IEnumerable<string> Results) : ICommand
{
    private const string DirectoryResult = "dir ";
    
    public Dictionary<string,List<File>> Execute(string currentDirectory, Dictionary<string,List<File>> currentFileSystem)
    {
        var directories = GetDirectoryResults(currentDirectory);
        var files = GetFileResults();

        currentFileSystem.AddRange(directories);
        currentFileSystem[currentDirectory].AddRange(files);
        
        return currentFileSystem;
    }

    private IEnumerable<File> GetFileResults()
    {
        var fileResults = Results.Where(result => !result.StartsWith(DirectoryResult));
        return fileResults.Select(fileResult =>
        {
            var fileComponents = fileResult.Split(" ");
            return new File(fileComponents.Last(), int.Parse(fileComponents.First()));
        }).ToList();
    }

    private IEnumerable<KeyValuePair<string, List<File>>> GetDirectoryResults(string currentDirectory)
    {
        var directoryResults = Results.Where(result => result.StartsWith(DirectoryResult));
        var directories = directoryResults.Select(directoryResult => $"{currentDirectory}{directoryResult.Substring(DirectoryResult.Length, directoryResult.Length - DirectoryResult.Length)}/");
        return directories.Select(directory => new KeyValuePair<string, List<File>>(directory, new List<File>()));
    }
}