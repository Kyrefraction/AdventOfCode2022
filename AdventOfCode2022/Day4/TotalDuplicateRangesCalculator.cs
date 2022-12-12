using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day4;

public class TotalDuplicateRangesCalculator
{
    private readonly IEnumerable<((int, int), (int, int))> _pairs;
    public TotalDuplicateRangesCalculator(string filePath)
    {
        var input = FileReader.ExtractInput(filePath, Environment.NewLine);
        var parsedInput = input.Select(Parser.Parse);
        _pairs = parsedInput.Select(pair => (RangeParser.Parse(pair.Item1), (RangeParser.Parse(pair.Item2))));
    }

    public int Calculate()
    {
        return _pairs.Count(pair => DuplicateRangeCalculator.IsRangeDuplicated(pair.Item1, pair.Item2));
    }
}