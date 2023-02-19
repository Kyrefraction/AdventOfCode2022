using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day11.Parsers;

public static class MonkeyOperationParser
{
    private const string OperationMarker = "Operation: new = old ";

    private const string MultiplierMarker = "*";
    private const string AdditionMarker = "+";
    private const string OldMarker = "old";

    public static Func<int, int> Parse(string operationInformation)
    {
        var startIndex = operationInformation.IndexOf(OperationMarker, StringComparison.Ordinal) + OperationMarker.Length;
        var operationString = operationInformation.Substring(startIndex, operationInformation.Length - startIndex);

        if (IsMultiplicationOperation(operationString))
        {
            var multiplier = operationString[MultiplierMarker.Length..];
            if (multiplier.RemoveWhitespace() == OldMarker)
            {
                return worry => worry * worry;
            }

            return worry => worry * multiplier.ToInt();
        }

        var addend = operationString[AdditionMarker.Length..];
        if (addend.RemoveWhitespace() == OldMarker)
        {
            return worry => worry + worry;
        }
        
        return worry => worry + addend.ToInt();
    }

    private static bool IsMultiplicationOperation(string operationString)
    {
        return operationString.First().ToString() == MultiplierMarker;
    }
}