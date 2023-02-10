using AdventOfCode2022.Day01;

namespace AdventOfCode2022.Tests.Day01;

public class CalorieCountingServiceTests
{
    private CalorieCountingService _calorieCountingService = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _calorieCountingService = new CalorieCountingService("Day01/Resources/input.txt");
    }

    [TestCase(1, 69206)]
    [TestCase(3, 197400)]
    public void Calculates_greatest_n_sets(int n, int expected)
    {
        var result = _calorieCountingService.CalculateGreatestCalorieSetTotals(n);
        
        Console.WriteLine($"Highest {n} calorie total was {result}");
        Assert.That(result, Is.EqualTo(expected));
    }
}