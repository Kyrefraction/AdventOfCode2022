using AdventOfCode2022.Day14.Models;
using AdventOfCode2022.Utilities;
using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day14;

public class CaveSandSimulationService
{
    private readonly Cave _cave;
    public CaveSandSimulationService(string filePath, (int, int) sourceCoordinates)
    {
        var file = FileReader.ExtractInput(filePath, Environment.NewLine);
        var instructions = RockFormationParser.Parse(file).ToList();
        _cave = CaveGenerator.Generate(instructions, sourceCoordinates);
    }


    public int CalculateRestingSandCount()
    {
        var sandRestingCoordinates = new List<(int, int)>();

        try
        {
            while (true)
            {
                sandRestingCoordinates.Add(_cave.CreateSandUnit());
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine(_cave.Tiles.ToDisplayString());
            return sandRestingCoordinates.Count;
        }
    }
}