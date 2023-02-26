using AdventOfCode2022.Day13;

namespace AdventOfCode2022.Tests.Day13;

[TestFixture]
public class PairOrderServiceTests
{
    private const string TestInput = "Day13/Resources/testInput.txt";
    private const string LiveInput = "Day13/Resources/input.txt";

    [TestCase(TestInput, 13)]
    [TestCase(LiveInput, 5330)]
    public void FindsOrderedIndicesProduct(string filePath, int expectedResult)
    {
        var pairOrderService = new PairOrderService(filePath);
        var result = pairOrderService.FindOrderedIndicesSum();
        
        Console.WriteLine($"The product of correctly ordered indices is: {result}");
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
}