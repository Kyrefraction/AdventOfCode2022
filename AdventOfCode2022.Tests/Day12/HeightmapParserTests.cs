using AdventOfCode2022.Day12;

namespace AdventOfCode2022.Tests.Day12;

[TestFixture]
public class HeightmapParserTests
{
    [Test]
    public void Parses()
    {
        var input = new List<string>
        {
            "Sabqponm",
            "abcryxxl",
            "accszExk",
            "acctuvwj",
            "abdefghi"
        };

        var result = HeightmapParser.Parse(input, 'S', 'E');
        var expectedResult = new[,]
        {
            { 1, 1, 2, 17, 16, 15, 14, 13 }, 
            { 1, 2, 3, 18, 25, 24, 24, 12 },
            { 1, 3, 3, 19, 26, 26, 24, 11 },
            { 1, 3, 3, 20, 21, 22, 23, 10 },
            { 1, 2, 4, 5, 6, 7, 8, 9 }
        };

        Assert.That(result.heightMap.Heights, Is.EqualTo(expectedResult));
    }
}