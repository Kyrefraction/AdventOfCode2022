using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day1;

public class CalorieCounter
{
    private const string SplitValue = "\r\n\r\n";
    private readonly IEnumerable<IEnumerable<int>> _parsedInput;

    public CalorieCounter(string path)
    {
        var input = FileReader.ExtractInput(path, SplitValue);
        _parsedInput = Parser.Parse(input);
    }

    public int CalculateGreatestCalorieSetTotals(int numberOfSets)
    {
        return IntegerSupersetCalculator.CalculateGreatestFlattenedSetTotals(_parsedInput, numberOfSets);
    }
}