using AdventOfCode2022.Day14;

namespace AdventOfCode2022.Tests.Day14;

[TestFixture]
public class RockFormationParserTests
{
    [Test]
    public void Parses()
    {
        var input = new List<string>
        {
            "498,4 -> 498,6 -> 496,6",
            "503,4 -> 502,4 -> 502,9 -> 494,9"
        };

        var expectedResult = new List<List<(int, int)>>
        {
            new()
            {
                (498, 4), (498, 6), (496, 6)
            },
            new()
            {
                (503, 4), (502, 4), (502, 9), (494, 9)
            }
        };

        var result = RockFormationParser.Parse(input);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}