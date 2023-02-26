using AdventOfCode2022.Day13.Enums;

namespace AdventOfCode2022.Day13.Models;

public interface IPacket
{
    ListPacket ToListPacket();
    ComparisonResult Compare(IPacket packet);
}