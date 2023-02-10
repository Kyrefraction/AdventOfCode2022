using AdventOfCode2022.Day04;

namespace AdventOfCode2022.Tests.Day04;

public class ParserTests
{
    [TestCase("2-4,6-8", "2-4", "6-8")]
    [TestCase("2-3,4-5", "2-3", "4-5")]
    [TestCase("4-90,1-4", "4-90", "1-4")]
    public void Parses(string input, string expectedFirst, string expectedSecond)
    {
        var result = Parser.Parse(input);
        
        Assert.Multiple(() =>
        {
            Assert.That(result.Item1, Is.EqualTo(expectedFirst));
            Assert.That(result.Item2, Is.EqualTo(expectedSecond));
        });
    }
}