namespace AdventOfCode2022.Utilities;

public static class EnumerableUtilities
{
    public static IEnumerable<int> Range(int start, int end)
    {
        if (end < start)
        {
            for (var index = end; index <= start; index++)
                yield return index;
        }
        
        for (var index = start; index <= end; index++)
            yield return index;
    }
}