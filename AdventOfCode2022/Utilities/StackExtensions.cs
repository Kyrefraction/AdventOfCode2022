namespace AdventOfCode2022.Utilities;

public static class StackExtensions
{
    public static List<T> PopMany<T>(this Stack<T> stack, int quantity)
    {
        var result = new List<T>(quantity);
        while (quantity-- > 0 && stack.Count > 0)
        {
            result.Add(stack.Pop());
        }

        return result;
    }

    public static void PushMany<T>(this Stack<T> stack, List<T> elements)
    {
        foreach (var element in elements)
        {
            stack.Push(element);
        }
    }
}