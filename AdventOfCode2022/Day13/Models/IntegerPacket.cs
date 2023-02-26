namespace AdventOfCode2022.Day13.Models;

public record IntegerPacket(int Value) : IPacket
{
    public ListPacket ToListPacket()
    {
        return new ListPacket(new List<IPacket> { this });
    }

    public int Compare(IPacket packet)
    {
        return packet is not IntegerPacket right ? ToListPacket().Compare(packet) : Value.CompareTo(right.Value);
    }
}