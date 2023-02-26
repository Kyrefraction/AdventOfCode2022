using AdventOfCode2022.Day13.Enums;
using AdventOfCode2022.Day13.Models;
using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day13;

public class PairOrderService
{
    private readonly List<(IPacket left, IPacket right)> _input;
    public PairOrderService(string filePath)
    {
        _input = PacketParser.Parse(FileReader.ExtractInput(filePath, $"{Environment.NewLine}{Environment.NewLine}"));
    }
    
    public int FindOrderedIndicesSum()
    {
        var correctlyOrderedIndices = 0;
        for (var index = 0; index < _input.Count; index++)
        {
            if (_input[index].left.Compare(_input[index].right) == ComparisonResult.Ordered)
            {
                correctlyOrderedIndices += index + 1;
            }
        }

        return correctlyOrderedIndices;
    }
}