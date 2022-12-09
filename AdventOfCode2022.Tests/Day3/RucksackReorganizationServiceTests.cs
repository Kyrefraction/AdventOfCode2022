using AdventOfCode2022.Day3;

namespace AdventOfCode2022.Tests.Day3;

public class RucksackReorganizationServiceTests
{
    private RucksackReorganizationService _rucksackReorganizationService = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _rucksackReorganizationService = new RucksackReorganizationService("Day3/Resources/input.txt");
    }

    [Test]
    public void Reorganizes_rucksack()
    {
        var result = _rucksackReorganizationService.Reorganize();
        
        Console.WriteLine($"Reorganized rucksack value is {result}");
        const int expectedResult = 7826;
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}