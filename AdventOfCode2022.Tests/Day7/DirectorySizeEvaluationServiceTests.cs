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

    [Test]
    public void Finds_smallest_directory_of_required_size()
    {
        var result = _directorySizeEvaluationService.FindSmallestDirectoryOfRequiredSize();
        
        Console.WriteLine($"Smallest directory required to provide enough space had a size of {result}");
        const int expectedResult = 214171;
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}