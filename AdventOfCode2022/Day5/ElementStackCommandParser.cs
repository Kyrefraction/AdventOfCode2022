using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day5;

public static class ElementStackCommandParser
{
    private const string QuantityCommand = "move";
    private const string SourceCommand = "from";
    private const string DestinationCommand = "to";
    public static (int, int, int) Parse(string input)
    {
        var moveEnd = input.IndexOf(QuantityCommand, StringComparison.Ordinal) + QuantityCommand.Length;
        var sourceStart = input.IndexOf(SourceCommand, StringComparison.Ordinal);
        var sourceEnd = input.IndexOf(SourceCommand, StringComparison.Ordinal) + SourceCommand.Length;
        var destinationStart = input.IndexOf(DestinationCommand, StringComparison.Ordinal);
        var destinationEnd = input.IndexOf(DestinationCommand, StringComparison.Ordinal) + DestinationCommand.Length;

        var quantity = int.Parse(input.Substring(moveEnd, sourceStart - moveEnd).RemoveWhitespace());
        var source = int.Parse(input.Substring(sourceEnd, destinationStart - sourceEnd).RemoveWhitespace());
        var destination = int.Parse(input.Substring(destinationEnd, input.Length - destinationEnd).RemoveWhitespace());

        return (quantity, source, destination);
    }
}