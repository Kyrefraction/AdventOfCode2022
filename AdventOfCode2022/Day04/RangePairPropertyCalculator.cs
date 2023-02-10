using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day04;

public class RangePairPropertyCalculator
{
    private readonly IEnumerable<((int, int), (int, int))> _pairs;
    public RangePairPropertyCalculator(string filePath)
    {
        var input = FileReader.ExtractInput(filePath, Environment.NewLine);
        var parsedInput = input.Select(Parser.Parse);
        _pairs = parsedInput.Select(pair => (RangeParser.Parse(pair.Item1), (RangeParser.Parse(pair.Item2))));
    }

    public int CalculateTotalDuplicateRanges()
    {
        return _pairs.Count(pair => DuplicateRangeCalculator.IsRangeDuplicated(pair.Item1, pair.Item2));
    }

    public int CalculateTotalOverlappedRanges()
    {
        return _pairs.Count(pair => OverlappedRangeCalculator.IsRangeOverlapped(pair.Item1, pair.Item2));
    }
}