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
}