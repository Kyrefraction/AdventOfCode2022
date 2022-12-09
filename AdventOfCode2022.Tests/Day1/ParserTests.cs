using AdventOfCode2022.Day1;

namespace AdventOfCode2022.Tests.Day1;

public class ParserTests
{
    [Test]
    public void Parses()
    {
        var input = new List<string>
        {
            @"1000
            2000
            3000",
            
            @"4000",
            @"5000
            6000",
            
            @"7000
            8000
            9000",
            
            @"10000"
        };
        
        var parsedInput = new List<List<int>>
        {
            new()
            {
                1000,
                2000,
                3000
            },
            new()
            {
                4000
            },
            new()
            {
                5000,
                6000
            },
            new()
            {
                7000,
                8000,
                9000
            },
            new()
            {
                10000
            }
        };

        var result = Parser.Parse(input);
        Assert.That(result, Is.EqualTo(parsedInput));
    }
}