using AdventOfCode2022.Day13.Models;

namespace AdventOfCode2022.Day13;

public class PacketComparer : IComparer<IPacket>
{
    public int Compare(IPacket? left, IPacket? right)
    {
        if (left == null)
        {
            throw new ArgumentNullException(nameof(left), "left or right packet were null when attempting to compare");
        }

        if (right == null)
        {
            throw new ArgumentNullException(nameof(right), "left or right packet were null when attempting to compare");
        }

        return left.Compare(right);
    }
}