using AdventOfCode2022.Day5;

namespace AdventOfCode2022.Tests.Day5;

public class StackElementMoverTests
{
    [Test]
    public void Moves_elements()
    {
        var startingElements = new List<Stack<string>>
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

        var elementMover = new StackElementMover(startingElements);
        elementMover.Move(1, 2, 1);

        var expectedResult = new List<Stack<string>>
        {
            new(new List<string>
            {
                "Z",
                "N",
                "D"
            }),
            new(new List<string>
            {
                "M",
                "C"
            }),
            new(new List<string>
            {
                "P"
            })
        };

        Assert.That(elementMover.GetCurrentElementState(), Is.EqualTo(expectedResult));
    }
}