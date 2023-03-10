using AdventOfCode2022.Day14;

namespace AdventOfCode2022.Tests.Day14;

[TestFixture]
public class CaveSandSimulationServiceTests
{
    private const string TestInput = "Day14/Resources/testInput.txt";
    private const string LiveInput = "Day14/Resources/input.txt";
    private static readonly (int, int) SourceCoordinates = (500, 0);
    
    [TestCase(TestInput, 24)]
    [TestCase(LiveInput, 964)]
    public void CalculatesRestingSandCount(string filePath, int expectedResult)
    {
        var caveSandSimulationService = new CaveSandSimulationService(filePath, SourceCoordinates);

        var result = caveSandSimulationService.CalculateRestingSandCount();
        
        Console.WriteLine($"{result} units of sand came to rest, before subsequent sand units fell into the void");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [TestCase(TestInput, 93)]
    [TestCase(LiveInput, 32041)]
    public void CalculatesRestingSandCountWithFloor(string filePath, int expectedResult)
    {
        var caveSandSimulationService = new CaveSandSimulationService(filePath, SourceCoordinates);

        var result = caveSandSimulationService.CalculateRestingSandCountWithFloor();
        
        Console.WriteLine($"{result} units of sand came to rest, before subsequent sand units fell into the void");
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}