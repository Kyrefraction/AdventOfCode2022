using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day5;

public class SupplyCrateRelocationService
{
    private readonly StackElementMover _mover;
    private readonly List<(int, int, int)> _moveCommands;

    public SupplyCrateRelocationService(string filePath)
    {
        var input = FileReader.ExtractInput(filePath, "\r\n\r\n").ToList();
        var elementStack = ElementStackParser.Parse(input[0].Split(Environment.NewLine));
        _mover = new StackElementMover(elementStack);
        _moveCommands = input[1].Split(Environment.NewLine).Select(ElementStackCommandParser.Parse).ToList();
    }

    public string Relocate()
    {
        foreach (var (quantity, source, destination) in _moveCommands)
        {
            _mover.Move(quantity, source, destination);
        }

        return ElementStackSkimmer.Skim(_mover.GetCurrentElementState());
    }

    public string RelocateInChunks()
    {
        foreach (var (quantity, source, destination) in _moveCommands)
        {
            _mover.MoveInChunks(quantity, source, destination);
        }

        return ElementStackSkimmer.Skim(_mover.GetCurrentElementState());
    }
}