using AdventOfCode2022.Day13.Models;
using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day13;

public class PairOrderService
{
    private readonly List<string> _input;
    private static readonly List<IPacket> DividerPackets = new()
    {
        new ListPacket(new List<IPacket> { new IntegerPacket(2) }),
        new ListPacket(new List<IPacket> { new IntegerPacket(6) })
    };
    public PairOrderService(string filePath)
    {
        _input = FileReader.ExtractInput(filePath, $"{Environment.NewLine}{Environment.NewLine}").ToList();
    }
    
    public int FindOrderedIndicesSum()
    {
        var pairs = PacketParser.ParsePairs(_input);
        var correctlyOrderedIndices = 0;
        for (var index = 0; index < _input.Count; index++)
        {
            if (pairs[index].left.Compare(pairs[index].right) == ComparisonResult.Ordered)
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
        packets.Sort();
        //insert divider rows
        //put every row in order
        //Find divider row indices + 1
        //return product of indices
        throw new NotImplementedException();
    }
}