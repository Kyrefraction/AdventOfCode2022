using AdventOfCode2022.Day11.Parsers;

namespace AdventOfCode2022.Tests.Day11.Parsers;

[TestFixture]
public class MonkeyPositionParserTests
{
    [Test]
    public void Parses()
    {
        const string input = "Monkey 0:";

        const int expectedResult = 0;
        var result = MonkeyPositionParser.Parse(input);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}