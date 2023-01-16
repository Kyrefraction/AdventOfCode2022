using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day1;

public class CalorieCountingService
{
    private readonly string _splitValue = $"{Environment.NewLine}{Environment.NewLine}";
    private readonly IEnumerable<IEnumerable<int>> _parsedInput;

    public CalorieCountingService(string path)
    {
        var input = FileReader.ExtractInput(path, _splitValue);
        _parsedInput = Parser.Parse(input);
    }

    public int CalculateGreatestCalorieSetTotals(int numberOfSets)
    {
        return IntegerSupersetCalculator.CalculateGreatestFlattenedSetTotals(_parsedInput, numberOfSets);
    }
}