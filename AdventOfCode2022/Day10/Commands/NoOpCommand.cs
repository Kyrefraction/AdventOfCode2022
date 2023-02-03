namespace AdventOfCode2022.Day10.Commands;

public record NoOpCommand : ICommand
{
    private const int CycleDuration = 1;

    public (List<(int, int)>, int, int) Execute(int cycle, int register)
    {
        return (new List<(int, int)> { (cycle, register) }, cycle + CycleDuration, register);
    }
}