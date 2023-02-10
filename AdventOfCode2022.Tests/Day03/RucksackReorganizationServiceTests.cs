using AdventOfCode2022.Day03;

namespace AdventOfCode2022.Tests.Day03;

public class RucksackReorganizationServiceTests
{
    private RucksackReorganizationService _rucksackReorganizationService = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _rucksackReorganizationService = new RucksackReorganizationService("Day03/Resources/input.txt");
    }

    [Test]
    public void Reorganizes_rucksack()
    {
        var result = _rucksackReorganizationService.Reorganize();
        
        Console.WriteLine($"Reorganized rucksack value is {result}");
        const int expectedResult = 7826;
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Reassigns_badges()
    {
        var result = _rucksackReorganizationService.ReassignBadges();
        
        Console.WriteLine($"Reassigned badge value is {result}");
        const int expectedResult = 2577;
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}