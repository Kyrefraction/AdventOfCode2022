using AdventOfCode2022.Day04;

namespace AdventOfCode2022.Tests.Day04;

public class RangeParserTests
{
    [TestCase("2-4", 2, 4)]
    [TestCase("6-8", 6, 8)]
    [TestCase("500-10", 500, 10)]
    public void Parses(string input, int bottom, int top)
    {
        var result = RangeParser.Parse(input);
        Assert.Multiple(() =>
        {
            Assert.That(result.Item1, Is.EqualTo(bottom));
            Assert.That(result.Item2, Is.EqualTo(top));
        });
    }
}