using AdventOfCode2022.Day14;
using AdventOfCode2022.Day14.Models;

namespace AdventOfCode2022.Tests.Day14;

[TestFixture]
public class CaveGeneratorTests
{
    [Test]
    public void GeneratesCave()
    {
        var input = new List<List<(int, int)>>
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

        var sourceCoordinates = (500, 0);
        var expectedResult = new Cave(new[,]
        {
            {
                ".", ".", ".", ".", ".",
                ".", ".", ".", ".", "#"
            },
            {
                ".", ".", ".", ".", ".",
                ".", ".", ".", ".", "#"
            },
            {
                ".", ".", ".", ".", ".",
                ".", "#", ".", ".", "#"
            },
            {
                ".", ".", ".", ".", ".",
                ".", "#", ".", ".", "#"
            },
            {
                ".", ".", ".", ".", "#",
                "#", "#", ".", ".", "#"
            },
            {
                ".", ".", ".", ".", ".",
                ".", ".", ".", ".", "#"
            },
            {
                "+", ".", ".", ".", ".",
                ".", ".", ".", ".", "#"
            },
            {
                ".", ".", ".", ".", ".",
                ".", ".", ".", ".", "#"
            },
            {
                ".", ".", ".", ".", "#",
                "#", "#", "#", "#", "#"
            },
            {
                ".", ".", ".", ".", "#",
                ".", ".", ".", ".", "."
            }
        }, sourceCoordinates);

        var result = CaveGenerator.Generate(input, sourceCoordinates);
        Assert.Multiple(() =>
        {
            Assert.That(result.Tiles, Is.EqualTo(expectedResult.Tiles));
            Assert.That(result.SourceCoordinates, Is.EqualTo((6, 0)));
        });
    }
}