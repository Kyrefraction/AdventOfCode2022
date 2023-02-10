using AdventOfCode2022.Day03;

namespace AdventOfCode2022.Tests.Day03;

public class CommonCharacterFinderTests
{
    [TestCase("vJrwpWtwJgWr", "hcsFMMfFFhFp", 'p')]
    [TestCase("jqHRNqRjqzjGDLGL", "rsFMfFZSrLrFZsSL", 'L')]
    [TestCase("PmmdzqPrV", "vPwwTWBwg", "P")]
    public void Finds_common_character_two_inputs(string first, string second, char expectedCommonCharacter)
    {
        var result = CommonCharacterFinder.Find(first, second);
        
        Assert.That(result, Is.EqualTo(expectedCommonCharacter));
    }

    [TestCase("vJrwpWtwJgWrhcsFMMfFFhFp", "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "PmmdzqPrVvPwwTWBwg", 'r')]
    [TestCase("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "ttgJtRGJQctTZtZT", "CrZsJsPPZsGzwwsLwLmpwMDw", 'Z')]
    public void Finds_common_character_three_inputs(string first, string second, string third, char expectedCommonCharacter)
    {
        var result = CommonCharacterFinder.Find(first, second, third);
        
        Assert.That(result, Is.EqualTo(expectedCommonCharacter));
    }
}