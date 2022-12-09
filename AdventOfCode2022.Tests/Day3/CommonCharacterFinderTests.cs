using AdventOfCode2022.Day3;
using NUnit.Framework.Constraints;

namespace AdventOfCode2022.Tests.Day3;

public class CommonCharacterFinderTests
{
    [TestCase("vJrwpWtwJgWr", "hcsFMMfFFhFp", 'p')]
    [TestCase("jqHRNqRjqzjGDLGL", "rsFMfFZSrLrFZsSL", 'L')]
    [TestCase("PmmdzqPrV", "vPwwTWBwg", "P")]
    public void FindsCommonCharacter(string compartmentOne, string compartmentTwo, char expectedCommonCharacter)
    {
        var result = CommonCharacterFinder.Find(compartmentOne, compartmentTwo);
        
        Assert.That(result, Is.EqualTo(expectedCommonCharacter));
    }
}