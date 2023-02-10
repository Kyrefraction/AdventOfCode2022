namespace AdventOfCode2022.Day05;

public static class ElementStackSkimmer
{
    public static string Skim(IEnumerable<Stack<string>> elementStacks)
    {
        return elementStacks.Aggregate(string.Empty, (current, elementStack) => current + elementStack.Peek());
    }
}