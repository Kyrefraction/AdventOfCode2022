using AdventOfCode2022.Day8;
using NUnit.Framework.Constraints;

namespace AdventOfCode2022.Tests.Day8;

public class TreeScenicScoreCalculatorTests
{
    [Test]
    public void Calculates()
    {
        var input = new List<List<int>>
        {
            new() { 3, 0, 3, 7, 3 },
            new() { 2, 5, 5, 1, 2 },
            new() { 6, 5, 3, 3, 2 },
            new() { 3, 3, 5, 4, 9 },
            new() { 3, 5, 3, 9, 0 }
        };

        var result = TreeScenicScoresCalculator.Calculate(input).Max();
        const int expectedResult = 8;
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}