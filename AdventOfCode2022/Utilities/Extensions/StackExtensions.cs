namespace AdventOfCode2022.Utilities.Extensions;

public static class StackExtensions
{
    public static IEnumerable<T> PopMany<T>(this Stack<T> stack, int quantity)
    {
        var result = new List<T>(quantity);
        while (quantity-- > 0 && stack.Count > 0)
        {
            result.Add(stack.Pop());
        }

        return result;
    }
    
    public static IEnumerable<T> PopChunk<T>(this Stack<T> stack, int quantity)
    {
        var result = PopMany(stack, quantity);
        return result.Reverse();
    }

    public static void PushMany<T>(this Stack<T> stack, IEnumerable<T> elements)
    {
        foreach (var element in elements)
        {
            stack.Push(element);
        }
    }
}