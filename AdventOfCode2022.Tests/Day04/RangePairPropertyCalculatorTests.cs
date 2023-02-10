using AdventOfCode2022.Day04;

namespace AdventOfCode2022.Tests.Day04;

public class RangePairPropertyCalculatorTests
{
    private RangePairPropertyCalculator _rangePairPropertyCalculator = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _rangePairPropertyCalculator = new RangePairPropertyCalculator("Day04/Resources/input.txt");
    }

    [Test]
    public void Calculates_total_duplicate_ranges()
    {
        var result = _rangePairPropertyCalculator.CalculateTotalDuplicateRanges();
        
        Console.WriteLine($"Total number of duplicated ranges was {result}");
        const int expectedResult = 534;
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Calculates_total_ranges_with_overlap()
    {
        var result = _rangePairPropertyCalculator.CalculateTotalOverlappedRanges();
        
        Console.WriteLine($"Total number of overlapped ranges was {result}");
    }
}