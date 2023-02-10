using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day05;

public class SupplyCrateRelocationService
{
    private readonly string _splitValue = $"{Environment.NewLine}{Environment.NewLine}";
    private readonly StackElementMover _mover;
    private readonly List<(int, int, int)> _moveCommands;

    public SupplyCrateRelocationService(string filePath)
    {
        var input = FileReader.ExtractInput(filePath, _splitValue).ToList();
        var elementStack = ElementStackParser.Parse(input.First().Split(Environment.NewLine));
        _mover = new StackElementMover(elementStack);
        _moveCommands = input.Last().Split(Environment.NewLine).Select(ElementStackCommandParser.Parse).ToList();
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