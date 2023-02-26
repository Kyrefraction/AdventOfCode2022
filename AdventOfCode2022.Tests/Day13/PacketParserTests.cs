using System.Text.Json;
using AdventOfCode2022.Day13;
using AdventOfCode2022.Day13.Models;

namespace AdventOfCode2022.Tests.Day13;

[TestFixture]
public class PacketParserTests
{
    [Test]
    public void ParsesPairs()
    {
        var input = new List<string>
        {
            @"[1,1,3,1,1]
[1,1,5,1,1]"
        };

        var result = PacketParser.ParsePairs(input);
        var expectedLeftResult = new ListPacket(new List<IPacket>
        {
            new IntegerPacket(1), new IntegerPacket(1), new IntegerPacket(3), new IntegerPacket(1), new IntegerPacket(1)
        });
        
        var expectedRightResult = new ListPacket(new List<IPacket>
        {
            new IntegerPacket(1), new IntegerPacket(1), new IntegerPacket(5), new IntegerPacket(1), new IntegerPacket(1)
        });

        CollectionAssert.AreEqual(expectedLeftResult.Values, (result.First().left as ListPacket)!.Values);
        CollectionAssert.AreEqual(expectedRightResult.Values, (result.First().right as ListPacket)!.Values);
    }

    [Test]
    public void ParsesList()
    {
        var input = new List<string>
        {
            @"[1,1,3,1,1]
[1,1,5,1,1]
[1,1,5,1,1]"
        };
        
        var result = PacketParser.ParseList(input);
        var expectedResult = new List<IPacket>
        {
            new ListPacket(new List<IPacket>
            {
                new IntegerPacket(1), new IntegerPacket(1), new IntegerPacket(3), new IntegerPacket(1),
                new IntegerPacket(1)
            }),
            new ListPacket(new List<IPacket>
            {
                new IntegerPacket(1), new IntegerPacket(1), new IntegerPacket(5), new IntegerPacket(1),
                new IntegerPacket(1)
            }),
            new ListPacket(new List<IPacket>
            {
                new IntegerPacket(1), new IntegerPacket(1), new IntegerPacket(5), new IntegerPacket(1),
                new IntegerPacket(1)
            })
        };

        Assert.That(JsonSerializer.Serialize(result), Is.EqualTo(JsonSerializer.Serialize(expectedResult)));
    }
}