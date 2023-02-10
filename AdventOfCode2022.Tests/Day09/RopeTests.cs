using AdventOfCode2022.Day09;
using AdventOfCode2022.Day09.Enums;

namespace AdventOfCode2022.Tests.Day09;

public class RopeTests
{
    [Test]
    public void Moves()
    {
        var rope = new Rope(2);
        var input = new List<(Direction, int)>
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

        rope.Move(input);
        var result = rope.GetTailPositionHistory().Count;
        
        const int expectedResult = 13;
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}