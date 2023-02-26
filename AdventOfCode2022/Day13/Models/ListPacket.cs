using AdventOfCode2022.Day13.Enums;

namespace AdventOfCode2022.Day13.Models;

public record ListPacket(List<IPacket> Values) : IPacket
{
    public ListPacket ToListPacket()
    {
        return this;
    }

    public ComparisonResult Compare(IPacket packet)
    {
        var right = packet.ToListPacket();
        for (var index = 0; index < Math.Min(Values.Count, right.Values.Count); ++index)
        {
            var comparisonResult = Values[index].Compare(right.Values[index]);
            if (comparisonResult != ComparisonResult.Equal)
            {
                return comparisonResult;
            }
        }

        if (Values.Count < right.Values.Count)
        {
            return ComparisonResult.Ordered;
        }

        return Values.Count == right.Values.Count ? ComparisonResult.Equal : ComparisonResult.Unordered;
    }
}