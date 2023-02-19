using AdventOfCode2022.Day11;

namespace AdventOfCode2022.Tests.Day11;

[TestFixture]
public class MonkeyKeepAwayServiceTests
{
    private const string LiveInput = "Day11/Resources/input.txt";
    private const string TestInput = "Day11/Resources/testInput.txt";
    private MonkeyKeepAwayService _monkeyKeepAwayService = null!;

    [TestCase(TestInput, 3, 20, 10605)]
    [TestCase(LiveInput, 3, 20, 56595)]
    [TestCase(TestInput, 1, 10000, 2713310158)]
    [TestCase(LiveInput, 1, 10000, 15693274740)]
    public void CalculatesMonkeyBusiness(string filePath, long postInspectionWorryDivisor, int numberOfRounds, long expectedResult)
    {
        _monkeyKeepAwayService = new MonkeyKeepAwayService(filePath);
        var result = _monkeyKeepAwayService.CalculateMonkeyBusiness(numberOfRounds, postInspectionWorryDivisor);
        
        Console.WriteLine($"Monkey business has been calculated as: {result}");
        Assert.That(result, Is.EqualTo(expectedResult));
    } 
}