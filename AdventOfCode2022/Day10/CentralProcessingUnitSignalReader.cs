using AdventOfCode2022.Day10.Commands;
using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day10;

public class CentralProcessingUnitSignalReader
{
    private static readonly List<int> ReadingCycles = new()
    {
        20,
        60,
        100,
        140,
        180,
        220
    };
    
    private readonly List<ICommand> _commands;
    public CentralProcessingUnitSignalReader(string filePath)
    {
        var input = FileReader.ExtractInput(filePath, Environment.NewLine);
        _commands = Parser.Parse(input);
    }

    public int ReadSignal()
    {
        var centralProcessingUnit = new CentralProcessingUnit();
        var readings = centralProcessingUnit.Execute(_commands);
        return readings
            .Where(reading => ReadingCycles.Contains(reading.cycle))
            .Select(reading => reading.cycle * reading.register).Sum();
    }
}