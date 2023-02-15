using AdventOfCode2022.Day10;

namespace AdventOfCode2022.Tests.Day10;

[TestFixture]
public class CathodeRayTubeDisplayReaderTests
{
    private const string Input = "Day10/Resources/input.txt";
    private CathodeRayTubeDisplayReader _cathodeRayTubeDisplayReader = null!;
    
    [Test]
    public void ReadsSignalStrength()
    {
        _cathodeRayTubeDisplayReader = new CathodeRayTubeDisplayReader(Input);
        var result = _cathodeRayTubeDisplayReader.ReadDisplay();
        
        Console.WriteLine($"Cathode ray tube is displaying:{Environment.NewLine}{result}");
        const string expectedResult = @"###...##..###..#..#.####.#..#.####...##.
#..#.#..#.#..#.#.#..#....#.#..#.......#.
#..#.#..#.#..#.##...###..##...###.....#.
###..####.###..#.#..#....#.#..#.......#.
#....#..#.#....#.#..#....#.#..#....#..#.
#....#..#.#....#..#.#....#..#.####..##..";
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}