using AdventOfCode2022.Day11.Parsers;
using AdventOfCode2022.Utilities;
using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day11;

public class MonkeyKeepAwayService
{
    private const int ActiveMonkeyThreshold = 2;
    private readonly List<Monkey> _monkeys;
    public MonkeyKeepAwayService(string filePath)
    {
        var file = FileReader.ExtractInput(filePath, $"{Environment.NewLine}{Environment.NewLine}");
        _monkeys = MonkeyParser.Parse(file);
    }

    public int CalculateMonkeyBusiness(int numberOfRounds)
    {
        for (var index = 0; index < numberOfRounds; index++)
        {
            foreach (var thrownItem in _monkeys.Select(monkey => monkey.InspectItems()).SelectMany(thrownItems => thrownItems))
            {
                _monkeys[thrownItem.destination].ReceiveItem(thrownItem.worryLevel);
            }
        }

        var mostActiveMonkeys = _monkeys
            .OrderByDescending(monkey => monkey.NumberOfInspections())
            .Take(ActiveMonkeyThreshold)
            .Select(activeMonkey => activeMonkey.NumberOfInspections());
        return mostActiveMonkeys.Product();
    }
}