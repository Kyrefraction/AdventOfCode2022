namespace AdventOfCode2022.Day7.Models.Commands;

public static class ChangeToPreviousDirectoryCommand
{
    private const string RootDirectory = "/";
    private const string DirectorySeparator = "/";

    public static string Execute(string currentDirectory)
    {
        if (currentDirectory == RootDirectory) {
            return RootDirectory;
        }

        var lastDirectorySeparatorIndex = currentDirectory.LastIndexOf(DirectorySeparator, StringComparison.Ordinal);
        var penultimateDirectorySeparatorIndex = currentDirectory[..lastDirectorySeparatorIndex].LastIndexOf(DirectorySeparator, StringComparison.Ordinal);

        return currentDirectory[..(penultimateDirectorySeparatorIndex + DirectorySeparator.Length)];
    }
}