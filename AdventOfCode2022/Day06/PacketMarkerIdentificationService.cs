using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day06;

public class PacketMarkerIdentificationService
{
    private readonly string _input;
    public PacketMarkerIdentificationService(string filePath)
    {
        _input = FileReader.ExtractInput(filePath);
    }

    public int RetrieveMarkerLocation(int markerLength)
    {
        return AllUniqueCharacterClusterLocationFinder.Find(_input, markerLength);
    }
}