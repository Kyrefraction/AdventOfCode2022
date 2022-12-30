using AdventOfCode2022.Day9.Enums;

namespace AdventOfCode2022.Day9;

public static class RopeMovementCommandParser
{
    public static IEnumerable<(Direction, int)> Parse(IEnumerable<string> input)
    {
        return input.Select(line => line.Split(" ")).Select(parts => (MapDirection(parts[0]), int.Parse(parts[1])));
    }

    private static Direction MapDirection(string direction)
    {
        return direction switch
        {
            "U" => Direction.Up,
            "R" => Direction.Right,
            "D" => Direction.Down,
            "L" => Direction.Left,
            _ => throw new ArgumentOutOfRangeException($"Unexpected direction: {direction} when attempting to parse")
        };
    }
}