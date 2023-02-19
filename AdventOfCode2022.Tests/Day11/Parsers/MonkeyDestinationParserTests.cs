using AdventOfCode2022.Day11.Parsers;

namespace AdventOfCode2022.Tests.Day11.Parsers;

[TestFixture]
public class MonkeyDestinationParserTests
{
    [Test]
    public void ParsesTrueDestination()
    {
        const string input = "    If true: throw to monkey 2";

        const int expectedResult = 2;
        var result = MonkeyDestinationParser.Parse(input);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void ParsesFalseDestination()
    {
        const string input = "    If false: throw to monkey 3";

        const int expectedResult = 3;
        var result = MonkeyDestinationParser.Parse(input);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}