using AdventOfCode2022.Day10.Commands;
using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day10;

public class CathodeRayTubeDisplayReader
{
    private readonly List<ICommand> _commands;
    private readonly CentralProcessingUnit _centralProcessingUnit;
    private readonly CathodeRayTubeDisplay _cathodeRayTubeDisplay;
    
    public CathodeRayTubeDisplayReader(string filePath)
    {
        var input = FileReader.ExtractInput(filePath, Environment.NewLine);
        _commands = Parser.Parse(input);
        _centralProcessingUnit = new CentralProcessingUnit();
        _cathodeRayTubeDisplay = new CathodeRayTubeDisplay();
    }
    
    public string ReadDisplay()
    {
        var readings = _centralProcessingUnit.Execute(_commands).ToList();
        
        for (var cycle = 1; cycle <= readings.Last().cycle; cycle++)
        {
            var register = readings.FirstOrDefault(reading => reading.cycle == cycle).register;
            var spritePixels = new List<int> { register - 1, register, register + 1 };
            _cathodeRayTubeDisplay.ExecuteCycle(spritePixels);
        }

        return _cathodeRayTubeDisplay.RetrieveDisplay();
    }
}