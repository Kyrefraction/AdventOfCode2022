using AdventOfCode2022.Day05;

namespace AdventOfCode2022.Tests.Day05;

public class ElementStackSkimmerTests
{
    [Test]
    public void Skims()
    {
        var input = new List<Stack<string>>
        {
            new(new List<string>
            {
                "C"
            }),
            new(new List<string>
            {
                "M"
            }),
            new(new List<string>
            {
                "P",
                "D",
                "N",
                "Z"
            })
        };
        
        const string expectedResult = "CMZ";

        var result = ElementStackSkimmer.Skim(input);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}