namespace AdventOfCode2022.Utilities.Extensions;

public static class ListExtensions
{
    public static List<List<T>> Partition<T>(this IEnumerable<T> list, int partitionSize) 
    {
        return list
            .Select((value, index) => new { Index = index, Value = value })
            .GroupBy(entry => entry.Index / partitionSize)
            .Select(groupedEntries => groupedEntries.Select(entry => entry.Value)
                .ToList())
            .ToList();
    }
    
    public static int Product(this IEnumerable<int> list)
    {
        return list.Aggregate((elementOne, elementTwo) => elementOne * elementTwo);
    }

    public static long Product(this IEnumerable<long> list)
    {
        return list.Aggregate((elementOne, elementTwo) => elementOne * elementTwo);
    }
}