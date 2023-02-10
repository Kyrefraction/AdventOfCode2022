using AdventOfCode2022.Day06;

namespace AdventOfCode2022.Tests.Day06;

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