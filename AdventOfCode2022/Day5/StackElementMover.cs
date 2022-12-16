using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day5;

public class StackElementMover
{
    private readonly List<Stack<string>> _elementStacks;

    public StackElementMover(List<Stack<string>> startingElementStackState)
    {
        _elementStacks = startingElementStackState;
    }

    public void Move(int quantity, int source, int destination)
    {
        var elementsToMove = _elementStacks[source - 1].PopMany(quantity);
        _elementStacks[destination - 1].PushMany(elementsToMove);
    }

    public List<Stack<string>> GetCurrentElementState()
    {
        return _elementStacks;
    }
}