using AdventOfCode2022.Day11;

namespace AdventOfCode2022.Tests.Day11;

[TestFixture]
public class MonkeyKeepAwayServiceTests
{
    private const string LiveInput = "Day11/Resources/input.txt";
    private const string TestInput = "Day11/Resources/testInput.txt";
    private MonkeyKeepAwayService _monkeyKeepAwayService = null!;

    [TestCase(TestInput, 10605)]
    [TestCase(LiveInput, 56595)]
    public void CalculatesMonkeyBusiness(string filePath, int expectedResult)
    {
        _monkeyKeepAwayService = new MonkeyKeepAwayService(filePath);
        const int numberOfRounds = 20;
        var result = _monkeyKeepAwayService.CalculateMonkeyBusiness(numberOfRounds);
        
        Console.WriteLine($"Monkey business has been calculated as: {result}");
        Assert.That(result, Is.EqualTo(expectedResult));
    } 
}