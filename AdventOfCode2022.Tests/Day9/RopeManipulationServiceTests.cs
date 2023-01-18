using AdventOfCode2022.Day9;

namespace AdventOfCode2022.Tests.Day9;

public class RopeManipulationServiceTests
{
    private RopeManipulationService _ropeManipulationService = null!;
    
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _ropeManipulationService = new RopeManipulationService("Day9/Resources/input.txt");
    }

    [Test]
    public void Counts_unique_tail_locations_after_moving()
    {
        var result = _ropeManipulationService.Move(2);
        
        Console.WriteLine($"Number of unique tail locations is: {result}");
        const int expectedResult = 6067;
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void Counts_unique_tail_locations_after_moving_with_ten_knot_rope()
    {
        var result = _ropeManipulationService.Move(10);
        
        Console.WriteLine($"Number of unique tail locations is: {result}");
        const int expectedResult = 2471;
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}