using AdventOfCode2022.Day11.Parsers;

namespace AdventOfCode2022.Tests.Day11.Parsers;

[TestFixture]
public class MonkeyOperationParserTests
{
    [Test]
    public void ParsesMultiplication()
    {
        const string input = "  Operation: new = old * 19";

        var expectedResult = new Func<int, int>(worry => worry * 19);
        var result = MonkeyOperationParser.Parse(input);
        
        const int testValue = 6;
        Assert.That(result(testValue), Is.EqualTo(expectedResult(testValue)));
    }

    [Test]
    public void ParsesAddition()
    {
        const string input = "  Operation: new = old + 6";

        var expectedResult = new Func<int, int>(worry => worry + 6);
        var result = MonkeyOperationParser.Parse(input);

        const int testValue = 6;
        Assert.That(result(testValue), Is.EqualTo(expectedResult(testValue)));
    }
}