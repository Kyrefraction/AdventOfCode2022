namespace AdventOfCode2022.Day11.Parsers;

public static class MonkeyParser
{
    private const int PositionElement = 0;
    private const int StartingItemsElement = 1;
    private const int OperationElement = 2;
    private const int TestElement = 3;
    private const int TrueDestinationElement = 4;
    private const int FalseDestinationElement = 5;
    
    public static List<Monkey> Parse(IEnumerable<string> monkeyInput)
    {
        return monkeyInput.Select(ParseMonkey).ToList();
    }

    private static Monkey ParseMonkey(string monkeyInformation)
    {
        var lines = monkeyInformation.Split(Environment.NewLine);
        var position = MonkeyPositionParser.Parse(lines[PositionElement]);
        var startingItems = MonkeyStartingItemsParser.Parse(lines[StartingItemsElement]);
        var operation = MonkeyOperationParser.Parse(lines[OperationElement]);
        var test = MonkeyTestParser.Parse(lines[TestElement]);
        var trueDestination = MonkeyDestinationParser.Parse(lines[TrueDestinationElement]);
        var falseDestination = MonkeyDestinationParser.Parse(lines[FalseDestinationElement]);

        return new Monkey(position, startingItems, operation, test, (trueDestination, falseDestination));
    }
}