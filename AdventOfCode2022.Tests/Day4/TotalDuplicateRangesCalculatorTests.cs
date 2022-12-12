using AdventOfCode2022.Day4;

namespace AdventOfCode2022.Tests.Day4;

public class TotalDuplicateRangesCalculatorTests
{
    private TotalDuplicateRangesCalculator _totalDuplicateRangesCalculator = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _totalDuplicateRangesCalculator = new TotalDuplicateRangesCalculator("Day4/Resources/input.txt");
    }

    [Test]
    public void Calculates_total_duplicate_ranges()
    {
        var result = _totalDuplicateRangesCalculator.Calculate();
        
        Console.WriteLine($"Total number of duplicate ranges between pairs was {result}");
    }
}