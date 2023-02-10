using AdventOfCode2022.Day08;

namespace AdventOfCode2022.Tests.Day08;

public class TreePatchParserTests
{
    [Test]
    public void Parses()
    {
        var input = new List<string>
        {
            "30373",
            "25512",
            "65332",
            "33549",
            "35390"
        };
        
        var expectedResult = new List<List<int>>
        {
            new() { 3, 0, 3, 7, 3 },
            new() { 2, 5, 5, 1, 2 },
            new() { 6, 5, 3, 3, 2 },
            new() { 3, 3, 5, 4, 9 },
            new() { 3, 5, 3, 9, 0 }
        };

        var result = TreePatchParser.Parse(input);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}