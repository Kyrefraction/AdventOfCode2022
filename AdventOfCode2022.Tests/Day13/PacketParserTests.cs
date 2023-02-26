using System.Runtime.CompilerServices;
using AdventOfCode2022.Day13;
using AdventOfCode2022.Day13.Models;

namespace AdventOfCode2022.Tests.Day13;

[TestFixture]
public class PacketParserTests
{
    [Test]
    public void Parses()
    {
        var input = new List<string>
        {
            @"[1,1,3,1,1]
[1,1,5,1,1]"
        };

        var result = PacketParser.Parse(input);
        var expectedLeftResult = new ListPacket(new List<IPacket>
        {
            new IntegerPacket(1), new IntegerPacket(1), new IntegerPacket(3), new IntegerPacket(1), new IntegerPacket(1)
        });
        
        var expectedRightResult = new ListPacket(new List<IPacket>
        {
            new IntegerPacket(1), new IntegerPacket(1), new IntegerPacket(5), new IntegerPacket(1), new IntegerPacket(1)
        });

        CollectionAssert.AreEqual((result.First().left as ListPacket)!.Values, expectedLeftResult.Values);
        CollectionAssert.AreEqual((result.First().right as ListPacket)!.Values, expectedRightResult.Values);
    }
    
}