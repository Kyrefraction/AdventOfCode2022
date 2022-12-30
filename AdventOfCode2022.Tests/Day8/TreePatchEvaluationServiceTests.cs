using AdventOfCode2022.Day8;

namespace AdventOfCode2022.Tests.Day8;

public class TreePatchEvaluationServiceTests
{
    private TreePatchEvaluationService _treePatchEvaluationService = null!;
    
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _treePatchEvaluationService = new TreePatchEvaluationService("Day8/Resources/input.txt");
    }

    [Test]
    public void Evaluates_number_of_visible_trees()
    {
        var result = _treePatchEvaluationService.EvaluateNumberOfVisibleTrees();
        
        Console.WriteLine($"There are {result} visible trees within the tree patch");
        const int expectedResult = 1825;
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}