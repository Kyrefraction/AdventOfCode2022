using AdventOfCode2022.Day03;

namespace AdventOfCode2022.Tests.Day03;

public class CharacterToIntegerConverterTests
{
    [TestCase('a', 1)]
    [TestCase('z', 26)]
    [TestCase('A', 27)]
    [TestCase('Z', 52)]
    public void Converts(char character, int value)
    {
        var result = CharacterToIntegerConverter.Convert(character);
        
        Assert.That(result, Is.EqualTo(value));
    }
}