namespace AdventOfCode2022.Day7.Models.Commands;

public static class ChangeToSpecificDirectoryCommand
{
    public static string Execute(string currentDirectory, string targetDirectory)
    {
        return $"{currentDirectory}{targetDirectory}/";
    }
}