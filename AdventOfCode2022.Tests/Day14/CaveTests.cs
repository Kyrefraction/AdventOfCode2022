using AdventOfCode2022.Day14.Models;
using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Tests.Day14;

[TestFixture]
public class CaveTests
{
    [Test]
    public void CreatesSandUnit()
    {
        var cave = new Cave(new[,]
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
        }, (6, 0));

        var result = cave.SpawnSand();
        Console.WriteLine(cave.Tiles.ToDisplayString());
        var expectedResult = (6, 8);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}