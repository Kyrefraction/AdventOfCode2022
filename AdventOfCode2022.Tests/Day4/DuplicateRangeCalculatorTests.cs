using AdventOfCode2022.Day4;

namespace AdventOfCode2022.Tests.Day4;

public class DuplicateRangeCalculatorTests
{

    [TestCase(2, 8, 3, 7, true)]
    [TestCase(4, 6, 6, 6, true)]
    [TestCase(2, 4, 6, 8, false)]
    public void Finds_duplicate_range(int firstBottom, int firstTop, int secondBottom, int secondTop, bool expectedResult)
    {
        var result = DuplicateRangeCalculator.IsRangeDuplicated((firstBottom, firstTop), (secondBottom, secondTop));
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}