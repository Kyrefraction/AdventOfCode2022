using AdventOfCode2022.Day05;

namespace AdventOfCode2022.Tests.Day05;

public class ElementStackCommandParserTests
{
    [TestCase("move 1 from 2 to 1", 1, 2, 1)]
    [TestCase("move 3 from 1 to 3", 3, 1, 3)]
    [TestCase("move 2 from 2 to 1", 2, 2, 1)]
    [TestCase("move 1 from 1 to 2", 1, 1, 2)]
    public void Parses(string input, int expectedQuantity, int expectedSource, int expectedDestination)
    {
        var result = ElementStackCommandParser.Parse(input);

        var expectedResult = (expectedQuantity, expectedSource, expectedDestination);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}