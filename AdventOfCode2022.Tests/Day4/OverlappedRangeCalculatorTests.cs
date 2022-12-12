using AdventOfCode2022.Day4;

namespace AdventOfCode2022.Tests.Day4;

public class OverlappedRangeCalculatorTests
{
    [TestCase(2, 4, 6, 8, false)]
    [TestCase(5, 7, 7, 9, true)]
    [TestCase(2, 8, 3, 7, true)]
    [TestCase(6, 6, 4, 6, true)]
    [TestCase(2, 6, 4, 6, true)]
    public void Calculates_if_range_is_overlapped(int firstBottom, int firstTop, int secondBottom, int secondTop, bool expectedResult)
    {
        var result = OverlappedRangeCalculator.IsRangeOverlapped((firstBottom, firstTop), (secondBottom, secondTop));
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}