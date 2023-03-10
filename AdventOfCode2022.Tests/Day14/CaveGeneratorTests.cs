using AdventOfCode2022.Day14;
using AdventOfCode2022.Day14.Models;
using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Tests.Day14;

[TestFixture]
public class CaveGeneratorTests
{
    private readonly List<List<(int, int)>> _input = new()
    {
        new List<(int, int)>
        {
            (498, 4), (498, 6), (496, 6)
        },
        new List<(int, int)>
        {
            (503, 4), (502, 4), (502, 9), (494, 9)
        }
    };

    private readonly (int, int) _sourceCoordinates = (500, 0);
    
    [Test]
    public void GeneratesCave()
    {
        var result = CaveGenerator.Generate(_input, _sourceCoordinates);
        Console.WriteLine(result.Tiles.ToDisplayString());
        Assert.That(result.SourceCoordinates, Is.EqualTo((6, 0)));
    }

    [Test]
    public void GeneratesCaveWithFloor()
    {
        var result = CaveGenerator.GenerateWithFloor(_input, _sourceCoordinates);
        Console.WriteLine(result.Tiles.ToDisplayString());
        Assert.That(result.SourceCoordinates, Is.EqualTo((500, 0)));
    }
}