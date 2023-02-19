using AdventOfCode2022.Day11.Parsers;

namespace AdventOfCode2022.Tests.Day11.Parsers;

[TestFixture]
public class MonkeyStartingItemsParserTests
{
    [Test]
    public void Parses()
    {
        const string input = "  Starting items: 79, 98";

        var expectedResult = new List<int> { 79, 98 };
        var result = MonkeyStartingItemsParser.Parse(input);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}