using AdventOfCode2022.Day6;

namespace AdventOfCode2022.Tests.Day6;

public class PacketMarkerIdentificationServiceTests
{
    private PacketMarkerIdentificationService _packetMarkerIdentificationService = null!;
    private const int PacketMarkerLength = 4;
    private const int MessageMarkerLength = 14;

    [SetUp]
    public void SetUp()
    {
        _packetMarkerIdentificationService = new PacketMarkerIdentificationService("Day6/Resources/input.txt");
    }

    [Test]
    public void Find_packet_marker_location()
    {
        var result = _packetMarkerIdentificationService.RetrieveMarkerLocation(PacketMarkerLength);
        
        Console.WriteLine($"Packet marker was present after character {result}");
        const int expectedResult = 1655;
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void Find_message_marker_location()
    {
        var result = _packetMarkerIdentificationService.RetrieveMarkerLocation(MessageMarkerLength);
        
        Console.WriteLine($"Message marker was present after character {result}");
        const int expectedResult = 2665;
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}