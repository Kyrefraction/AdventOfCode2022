using AdventOfCode2022.Day08;

namespace AdventOfCode2022.Tests.Day08;

public class TreeVisibilityCalculatorTests
{
    [Test]
    public void Calculates_number_of_visible_trees()
    {
        var input = new List<List<int>>
        {
            new() { 3, 0, 3, 7, 3 },
            new() { 2, 5, 5, 1, 2 },
            new() { 6, 5, 3, 3, 2 },
            new() { 3, 3, 5, 4, 9 },
            new() { 3, 5, 3, 9, 0 }
        };

        const int expectedResult = 21;
        var result = TreeVisibilityCalculator.Calculate(input);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}