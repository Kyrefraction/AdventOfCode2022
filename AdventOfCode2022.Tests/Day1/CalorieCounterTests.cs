using AdventOfCode2022.Day1;

namespace AdventOfCode2022.Tests.Day1;

public class CalorieCounterTests
{
    private CalorieCounter _calorieCounter = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _calorieCounter = new CalorieCounter("Day1/Resources/input.txt");
    }

    [TestCase(1, 69206)]
    [TestCase(3, 197400)]
    public void Calculates_greatest_n_sets(int n, int expected)
    {
        var result = _calorieCounter.CalculateGreatestCalorieSetTotals(n);
        
        Console.WriteLine($"Highest {n} calorie total was {result}");
        Assert.That(result, Is.EqualTo(expected));
    }
}