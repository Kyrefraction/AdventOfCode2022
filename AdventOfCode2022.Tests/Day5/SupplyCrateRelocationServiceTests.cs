using AdventOfCode2022.Day5;

namespace AdventOfCode2022.Tests.Day5;

public class SupplyCrateRelocationServiceTests
{
    private SupplyCrateRelocationService _supplyCrateRelocationService = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _supplyCrateRelocationService = new SupplyCrateRelocationService("Day5/Resources/input.txt");
    }
    
    [Test]
    public void Relocates()
    {
        var result = _supplyCrateRelocationService.Relocate();
        
        Console.WriteLine($"End state of element stacks is {result}");
        const string expectedResult = "BSDMQFLSP";
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}