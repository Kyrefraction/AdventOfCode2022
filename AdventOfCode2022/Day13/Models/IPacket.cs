namespace AdventOfCode2022.Day13.Models;

public interface IPacket
{
    ListPacket ToListPacket();
    int Compare(IPacket packet);
}