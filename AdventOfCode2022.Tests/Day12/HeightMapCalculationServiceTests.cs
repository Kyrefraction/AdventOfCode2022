using AdventOfCode2022.Day12;

namespace AdventOfCode2022.Tests.Day12;

[TestFixture]
public class HeightMapCalculationServiceTests
{
    private HeightMapCalculationService _heightMapCalculationService = null!;
    private const string LiveInput = "Day12/Resources/input.txt";
    private const string TestInput = "Day12/Resources/testInput.txt";
    
    [TestCase(TestInput, 'E', 'S', 31)]
    [TestCase(LiveInput, 'E', 'S', 383)]
    [TestCase(TestInput, 'E', 'a', 29)]
    [TestCase(LiveInput, 'E', 'a', 377)]
    public void FindsHeightMap(string filePath, char root, char destination, int expectedResult)
    {
        _heightMapCalculationService = new HeightMapCalculationService(filePath, root, destination);

        var result = _heightMapCalculationService.FindFewestSteps();
        
        Console.WriteLine($"Fewest number of steps was found to be: {result}");
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}