namespace AdventOfCode2022.Day7.Models.Commands;

public record ChangeDirectoryCommand(string TargetDirectory) : ICommand
{
    private const string RootDirectory = "/";
    private const string PreviousDirectory = "..";
    public string Execute(string currentDirectory)
    {
        return TargetDirectory switch
        {
            RootDirectory => ChangeToRootDirectoryCommand.Execute(),
            PreviousDirectory => ChangeToPreviousDirectoryCommand.Execute(currentDirectory),
            _ => ChangeToSpecificDirectoryCommand.Execute(currentDirectory, TargetDirectory)
        };
    }
}