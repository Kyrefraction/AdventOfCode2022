using AdventOfCode2022.Day7;

namespace AdventOfCode2022.Tests.Day7;

public class DirectorySizeEvaluationServiceTests
{
    private DirectorySizeEvaluationService _directorySizeEvaluationService = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _directorySizeEvaluationService = new DirectorySizeEvaluationService("Day7/Resources/input.txt");
    }
    
    [Test]
    public void Evaluates()
    {
        var result = _directorySizeEvaluationService.Evaluate();
        
        Console.WriteLine($"Directories totalled {result}");
        const int expectedResult = 1583951;
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}