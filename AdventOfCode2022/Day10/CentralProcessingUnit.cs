using AdventOfCode2022.Day10.Commands;

namespace AdventOfCode2022.Day10;

public class CentralProcessingUnit
{
    private const int DefaultCycleValue = 1;
    private const int DefaultRegisterValue = 1;
    private int _cycle;
    private int _register;
    public CentralProcessingUnit()
    {
        _cycle = DefaultCycleValue;
        _register = DefaultRegisterValue;
    }

    public IEnumerable<(int cycle, int register)> Execute(IEnumerable<ICommand> commands)
    {
        var readings = new List<(int, int)>();
        foreach (var result in commands.Select(command => command.Execute(_cycle, _register)))
        {
            readings.AddRange(result.readings);
            _cycle = result.cycle;
            _register = result.register;
        }
        
        return readings;
    }
}