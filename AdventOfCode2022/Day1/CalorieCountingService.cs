using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day1;

public class CalorieCountingService
{
    private const string SplitValue = "\r\n\r\n";
    private readonly IEnumerable<IEnumerable<int>> _parsedInput;

    public CalorieCountingService(string path)
    {
        var input = FileReader.ExtractInput(path, SplitValue);
        _parsedInput = Parser.Parse(input);
    }

    public int CalculateGreatestCalorieSetTotals(int numberOfSets)
    {
        return IntegerSupersetCalculator.CalculateGreatestFlattenedSetTotals(_parsedInput, numberOfSets);
    }
}