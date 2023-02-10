using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day05;

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
    
    public void MoveInChunks(int quantity, int source, int destination)
    {
        var elementsToMove = _elementStacks[source - 1].PopChunk(quantity);
        _elementStacks[destination - 1].PushMany(elementsToMove);
    }

    public List<Stack<string>> GetCurrentElementState()
    {
        return _elementStacks;
    }
}