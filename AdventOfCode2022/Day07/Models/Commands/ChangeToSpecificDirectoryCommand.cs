namespace AdventOfCode2022.Day07.Models.Commands;

public static class ChangeToSpecificDirectoryCommand
{
    public static string Execute(string currentDirectory, string targetDirectory)
    {
        return $"{currentDirectory}{targetDirectory}/";
    }
}