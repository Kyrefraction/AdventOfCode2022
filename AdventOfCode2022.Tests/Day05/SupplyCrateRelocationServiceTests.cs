using AdventOfCode2022.Day05;

namespace AdventOfCode2022.Tests.Day05;

public class SupplyCrateRelocationServiceTests
{
    private SupplyCrateRelocationService _supplyCrateRelocationService = null!;

    [SetUp]
    public void SetUp()
    {
        _supplyCrateRelocationService = new SupplyCrateRelocationService("Day05/Resources/input.txt");
    }
    
    [Test]
    public void Relocates()
    {
        var result = _supplyCrateRelocationService.Relocate();
        
        Console.WriteLine($"End state of element stacks after relocation is {result}");
        const string expectedResult = "BSDMQFLSP";
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Relocates_in_chunks()
    {
        var result = _supplyCrateRelocationService.RelocateInChunks();
        
        Console.WriteLine($"End state of element stacks after chunked relocation is {result}");
        const string expectedResult = "PGSQBFLDP";
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}