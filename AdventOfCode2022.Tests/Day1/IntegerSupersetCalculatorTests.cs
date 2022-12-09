using AdventOfCode2022.Day1;

namespace AdventOfCode2022.Tests.Day1;

public class IntegerSupersetCalculatorTests
{
    private static readonly List<List<int>> IntegerSuperset = new()
    {
        new List<int>
        {
            1000,
            2000,
            3000
        },
        new List<int>
        {
            4000
        },
        new List<int>
        {
            5000,
            6000
        },
        new List<int>
        {
            7000,
            8000,
            9000
        },
        new List<int>
        {
            10000
        }
    };
    
    [TestCase(1, 24000)]
    [TestCase(3, 45000)]
    public void Calculates_greatest_n_set_totals(int n, int expectedResult)
    {
        var result = IntegerSupersetCalculator.CalculateGreatestFlattenedSetTotals(IntegerSuperset, n);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}