using AdventOfCode2022.Day3;
using NUnit.Framework.Constraints;

namespace AdventOfCode2022.Tests.Day3;

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