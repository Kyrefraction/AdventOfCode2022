using AdventOfCode2022.Day10;
using AdventOfCode2022.Day10.Commands;

namespace AdventOfCode2022.Tests.Day10;

[TestFixture]
public class CentralProcessingUnitTests
{
    [Test]
    public void ExecutesNoOpCommands()
    {
        var commands = new List<ICommand>
        {
            new NoOpCommand(),
            new NoOpCommand(),
            new NoOpCommand()
        };

        var centralProcessingUnit = new CentralProcessingUnit();
        var readings = centralProcessingUnit.Execute(commands);

        var expectedReadings = new List<(int, int)>
        {
            (1, 1),
            (2, 1),
            (3, 1)
        };
        
        Assert.That(readings, Is.EqualTo(expectedReadings));
    }

    [Test]
    public void ExecutesAddCommands()
    {
        var commands = new List<ICommand>
        {
            new AddCommand(1),
            new AddCommand(1),
            new AddCommand(1)
        };

        var centralProcessingUnit = new CentralProcessingUnit();
        var readings = centralProcessingUnit.Execute(commands);

        var expectedReadings = new List<(int, int)>
        {
            (1, 1),
            (2, 1),
            (3, 2),
            (4, 2),
            (5, 3),
            (6, 3)
        };
        
        Assert.That(readings, Is.EqualTo(expectedReadings));
    }
}