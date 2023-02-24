using AdventOfCode2022.Day12;
using AdventOfCode2022.Day12.Models;

namespace AdventOfCode2022.Tests.Day12;

[TestFixture]
public class HeightMapTests
{
    [Test]
    public void FindsAccessibleNeighbours()
    {
        var heights = new[,]
        {
            { 1, 1, 2, 17, 16, 15, 14, 13 }, 
            { 1, 2, 3, 18, 25, 24, 24, 12 },
            { 1, 3, 3, 19, 26, 26, 24, 11 },
            { 1, 3, 3, 20, 21, 22, 23, 10 },
            { 1, 2, 4, 5, 6, 7, 8, 9 }
        };
        var heightMap = new HeightMap(heights);
        
        var result = heightMap.FindAccessibleNeighbours(new Vertex((3, 0)));
        var expectedResult = new List<Vertex>
        {
            new((2, 0)),
            new((4, 0))
        };
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
}