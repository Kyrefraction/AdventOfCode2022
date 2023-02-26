using AdventOfCode2022.Day13;
using AdventOfCode2022.Day13.Models;

namespace AdventOfCode2022.Tests.Day13;

[TestFixture]
public class PairOrderServiceTests
{
    private const string TestInput = "Day13/Resources/testInput.txt";
    private const string LiveInput = "Day13/Resources/input.txt";
    private readonly IComparer<IPacket> _packetComparer = new PacketComparer();

    [TestCase(TestInput, 13)]
    [TestCase(LiveInput, 5330)]
    public void FindsOrderedIndicesProduct(string filePath, int expectedResult)
    {
        var pairOrderService = new PairOrderService(filePath, _packetComparer);
        var result = pairOrderService.FindOrderedIndicesSum();
        
        Console.WriteLine($"The sum of correctly ordered indices is: {result}");
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [TestCase(TestInput, 140)]
    [TestCase(LiveInput, 27648)]
    public void FindsDecoderKey(string filePath, int expectedResult)
    {
        var pairOrderService = new PairOrderService(filePath, _packetComparer);
        var result = pairOrderService.FindDecoderKey();
        
        Console.WriteLine($"Decoder key value is: {result}");
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}