namespace AdventOfCode2022.Day13.Models;

public record IntegerPacket(int Value) : IPacket
{
    public ListPacket ToListPacket()
    {
        return new ListPacket(new List<IPacket> { this });
    }

    public int Compare(IPacket packet)
    {
        if (packet is not IntegerPacket right)
        {
            return ToListPacket().Compare(packet);
        }
        
        if (Value < right.Value)
        {
            return ComparisonResult.Ordered;
        }

        return Value == right.Value ? ComparisonResult.Equal : ComparisonResult.Unordered;
    }
}