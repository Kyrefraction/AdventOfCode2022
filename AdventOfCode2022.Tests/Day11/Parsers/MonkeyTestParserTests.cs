using AdventOfCode2022.Day11.Parsers;

namespace AdventOfCode2022.Tests.Day11.Parsers;

[TestFixture]
public class MonkeyTestParserTests
{
    [Test]
    public void Parses()
    {
        const string input = "  Test: divisible by 23";

        const int expectedResult = 23;
        var result = MonkeyTestParser.Parse(input);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}