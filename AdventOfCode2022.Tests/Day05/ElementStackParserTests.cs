using AdventOfCode2022.Day05;

namespace AdventOfCode2022.Tests.Day05;

public class ElementStackParserTests
{
    [Test]
    public void Parses()
    {
        var input = new List<string>
        {
            "    [D]    ",
            "[N] [C]    ",
            "[Z] [M] [P]",
            " 1   2   3"
        }.ToArray();
        
        var expectedResult = new List<Stack<string>>
        {
            new(new List<string>
            {
                "Z",
                "N"
            }),
            new(new List<string>
            {
                "M",
                "C",
                "D"
            }),
            new(new List<string>
            {
                "P"
            })
        };

        var result = ElementStackParser.Parse(input);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}