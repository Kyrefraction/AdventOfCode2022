using AdventOfCode2022.Day5;

namespace AdventOfCode2022.Tests.Day5;

public class StackElementMoverTests
{
    private StackElementMover _elementMover = null!;

    [SetUp]
    public void SetUp()
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

        _elementMover = new StackElementMover(startingElements);
    }
    
    [Test]
    public void Moves_elements()
    {
        _elementMover.Move(1, 2, 1);

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

        Assert.That(_elementMover.GetCurrentElementState(), Is.EqualTo(expectedResult));
    }

    [Test]
    public void Moves_elements_in_chunks()
    {
        _elementMover.MoveInChunks(1, 2, 1);
        _elementMover.MoveInChunks(3, 1, 3);
        
        var expectedResult = new List<Stack<string>>
        {
            new(new List<string>()),
            new(new List<string>
            {
                "M",
                "C"
            }),
            new(new List<string>
            {
                "P",
                "Z",
                "N",
                "D"
            })
        };

        Assert.That(_elementMover.GetCurrentElementState(), Is.EqualTo(expectedResult));
    }
}