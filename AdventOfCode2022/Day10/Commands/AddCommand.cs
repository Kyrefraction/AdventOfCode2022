namespace AdventOfCode2022.Day10.Commands;

public record AddCommand : ICommand
{
    private const int CycleDuration = 2;
    private readonly int _displacement;
    public AddCommand(int displacement)
    {
        _displacement = displacement;
    }
    
    public (List<(int, int)>, int, int) Execute(int cycle, int value)
    {
        var readings = new List<(int, int)>();
        for (var index = 0; index < CycleDuration; index++)
        {
            readings.Add((cycle + index, value));
        }

        return (readings, cycle + CycleDuration, value + _displacement);
    }
}