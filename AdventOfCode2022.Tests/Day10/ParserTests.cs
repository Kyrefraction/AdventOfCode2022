using AdventOfCode2022.Day10;
using AdventOfCode2022.Day10.Commands;

namespace AdventOfCode2022.Tests.Day10;

[TestFixture]
public class ParserTests
{
    [Test]
    public void Parses()
    {
        var input = new List<string>
        {
            "noop",
            "noop",
            "noop",
            "addx 6",
            "addx -1",
            "addx 5"
        };

        var expectedResult = new List<ICommand>
        {
            new NoOpCommand(),
            new NoOpCommand(),
            new NoOpCommand(),
            new AddCommand(6),
            new AddCommand(-1),
            new AddCommand(5),
        };

        var result = Parser.Parse(input);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}