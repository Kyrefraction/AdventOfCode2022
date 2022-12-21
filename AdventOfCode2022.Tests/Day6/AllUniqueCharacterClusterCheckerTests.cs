using AdventOfCode2022.Day6;

namespace AdventOfCode2022.Tests.Day6;

public class AllUniqueCharacterClusterCheckerTests
{
    [TestCase("mjqj", false)]
    [TestCase("jpqm", true)]
    public void Checks(string input, bool expectedResult)
    {
        var result = AllUniqueCharacterClusterChecker.Check(input);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}