using AdventOfCode2022.Day03;

namespace AdventOfCode2022.Tests.Day03;

public class StringDividerTests
{
    [TestCase("vJrwpWtwJgWrhcsFMMfFFhFp", "vJrwpWtwJgWr", "hcsFMMfFFhFp")]
    [TestCase("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "jqHRNqRjqzjGDLGL", "rsFMfFZSrLrFZsSL")]
    [TestCase("PmmdzqPrVvPwwTWBwg", "PmmdzqPrV", "vPwwTWBwg")]
    public void Halves(string input, string expectedFirstHalf, string expectedSecondHalf)
    {
        var result = StringDivider.Half(input);
        Assert.Multiple(() =>
        {
            Assert.That(result.Item1, Is.EqualTo(expectedFirstHalf));
            Assert.That(result.Item2, Is.EqualTo(expectedSecondHalf));
        });
    }
}