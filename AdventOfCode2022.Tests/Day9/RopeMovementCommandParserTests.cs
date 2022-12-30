using AdventOfCode2022.Day9;
using AdventOfCode2022.Day9.Enums;
using NUnit.Framework.Constraints;

namespace AdventOfCode2022.Tests.Day9;

public class RopeMovementCommandParserTests
{
    [Test]
    public void Parses()
    {
        var input = new List<string>
        {
            "R 4",
            "U 4",
            "L 3",
            "D 1",
            "R 4",
            "D 1",
            "L 5",
            "R 2"
        };

        var result = RopeMovementCommandParser.Parse(input);

        var expectedResult = new List<(Direction, int)>
        {
            (Direction.Right, 4),
            (Direction.Up, 4),
            (Direction.Left, 3),
            (Direction.Down, 1),
            (Direction.Right, 4),
            (Direction.Down, 1),
            (Direction.Left, 5),
            (Direction.Right, 2)
        };
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}