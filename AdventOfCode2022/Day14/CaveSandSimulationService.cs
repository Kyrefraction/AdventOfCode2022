using AdventOfCode2022.Day14.Models;
using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day14;

public class CaveSandSimulationService
{
    private readonly List<List<(int x, int y)>> _rockFormations;
    private readonly (int x, int y) _sourceCoordinates;
    public CaveSandSimulationService(string filePath, (int, int) sourceCoordinates)
    {
        _rockFormations = RockFormationParser.Parse(FileReader.ExtractInput(filePath, Environment.NewLine)).ToList();
        _sourceCoordinates = sourceCoordinates;
    }

    public int CalculateRestingSandCount()
    {
        var cave = CaveGenerator.Generate(_rockFormations, _sourceCoordinates);
        return CalculateRestingSandCount(cave);
    }

    public int CalculateRestingSandCountWithFloor()
    {
        var cave = CaveGenerator.GenerateWithFloor(_rockFormations, _sourceCoordinates);
        return CalculateRestingSandCount(cave);
    }

    private int CalculateRestingSandCount(Cave cave)
    {
        var restingSandCoordinates = new List<(int, int)>();

        try
        {
            while (true)
            {
                var restingSandCoordinate = cave.SpawnSand();
                restingSandCoordinates.Add(restingSandCoordinate);
                if (restingSandCoordinate == _sourceCoordinates)
                {
                    return restingSandCoordinates.Count;
                }
            }
        }
        catch (IndexOutOfRangeException)
        {
            return restingSandCoordinates.Count;
        }
    }
}