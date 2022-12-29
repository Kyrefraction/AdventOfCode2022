namespace AdventOfCode2022.Day7.Models.Commands;

public static class ChangeToRootDirectoryCommand
{
    private const string RootDirectory = "/";
    public static string Execute()
    {
        return RootDirectory;
    }
}