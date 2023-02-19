using AdventOfCode2022.Day11.Parsers;

namespace AdventOfCode2022.Tests.Day11.Parsers;

[TestFixture]
public class MonkeyTestParserTests
{
    [Test]
    public void Parses()
    {
        const string input = "  Test: divisible by 23";

        var expectedResult = new Func<int, bool>(worry => worry % 23 == 0);
        var result = MonkeyTestParser.Parse(input);
        
        const int testValue = 6;
        Assert.That(result(testValue), Is.EqualTo(expectedResult(testValue)));
    }
}