using AdventOfCode2022.Day13.Models;
using AdventOfCode2022.Utilities;
using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day13;

public class PairOrderService
{
    private readonly List<string> _input;
    private readonly IComparer<IPacket> _packetComparer;
    private static readonly List<IPacket> DividerPackets = new()
    {
        new ListPacket(new List<IPacket> { new IntegerPacket(2) }),
        new ListPacket(new List<IPacket> { new IntegerPacket(6) })
    };
    public PairOrderService(string filePath, IComparer<IPacket> packetComparer)
    {
        _packetComparer = packetComparer;
        _input = FileReader.ExtractInput(filePath, $"{Environment.NewLine}{Environment.NewLine}").ToList();
    }
    
    public int FindOrderedIndicesSum()
    {
        var pairs = PacketParser.ParsePairs(_input);
        var correctlyOrderedIndices = 0;
        for (var index = 0; index < _input.Count; index++)
        {
            if (_packetComparer.Compare(pairs[index].left, pairs[index].right) == ComparisonResult.Ordered)
            {
                correctlyOrderedIndices += index + 1;
            }
        }

        return correctlyOrderedIndices;
    }

    public int FindDecoderKey()
    {
        var packets = PacketParser.ParseList(_input);
        packets.AddRange(DividerPackets);
        packets.Sort(_packetComparer);

        var dividerIndices = DividerPackets.Select(dividerPacket => packets.FindIndex(packet => packet == dividerPacket) + 1);
        return dividerIndices.Product();
    }
}