using AdventOfCode2022.Day10;

namespace AdventOfCode2022.Tests.Day10;

[TestFixture]
public class CentralProcessingUnitSignalReaderTests
{
    private const string LiveInput = "Day10/Resources/input.txt";
    private const string TestInput = "Day10/Resources/testInput.txt";
    private CentralProcessingUnitSignalReader _centralProcessingUnitSignalReader = null!;
    
    [TestCase(TestInput, 13140)]
    [TestCase(LiveInput, 14060)]
    public void ReadsSignalStrength(string input, int expectedResult)
    {
        _centralProcessingUnitSignalReader = new CentralProcessingUnitSignalReader(input);
        var result = _centralProcessingUnitSignalReader.ReadSignal();
        
        Console.WriteLine($"Reported signal strength is: {result}");
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}