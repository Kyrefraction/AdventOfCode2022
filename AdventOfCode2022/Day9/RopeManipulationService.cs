using AdventOfCode2022.Day9.Enums;
using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day9;

public class RopeManipulationService
{
    private readonly IEnumerable<(Direction, int)> _parsedInput;

    public RopeManipulationService(string filePath)
    {
        var input = FileReader.ExtractInput(filePath, Environment.NewLine);
        _parsedInput = RopeMovementCommandParser.Parse(input);
    }

    public int Move(int knotQuantity)
    {
        var rope = new Rope(knotQuantity);
        rope.Move(_parsedInput);
        return rope.GetTailPositionHistory().Count;
    }
}