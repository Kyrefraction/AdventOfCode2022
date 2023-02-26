namespace AdventOfCode2022.Day13.Models;

public record ListPacket(List<IPacket> Values) : IPacket
{
    public ListPacket ToListPacket()
    {
        return this;
    }

    public int Compare(IPacket packet)
    {
        var right = packet.ToListPacket();
        for (var index = 0; index < Math.Min(Values.Count, right.Values.Count); index++)
        {
            var comparisonResult = Values[index].Compare(right.Values[index]);
            if (comparisonResult != ComparisonResult.Equal)
            {
                return comparisonResult;
            }
        }

        return Values.Count.CompareTo(right.Values.Count);
    }
}