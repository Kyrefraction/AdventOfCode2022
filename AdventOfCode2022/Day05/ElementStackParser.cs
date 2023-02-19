using System.Globalization;

namespace AdventOfCode2022.Day05;

public static class ElementStackParser
{
    private const int CharactersBetweenElements = 4;
    private const int LengthOfElements = 1;
    private const int NumberOfHeaderRows = 1;
    private const int FirstElementPosition = 1;

    public static List<Stack<string>> Parse(string[] input)
    {
        var elementStacks = InitializeElementStacks(input);
        var reversedInput = input.Reverse();
        foreach (var line in reversedInput.Skip(NumberOfHeaderRows))
        {
            for (var index = FirstElementPosition; index < line.Length; index += CharactersBetweenElements)
            {
                var element = line.Substring(index, LengthOfElements);
                if (!string.IsNullOrWhiteSpace(element))
                {
                    elementStacks[GetListIndex(index)].Push(element);
                }
            }
        }
        
        return elementStacks;
    }

    private static int GetListIndex(int lineIndex)
    {
        return int.Parse(Math.Ceiling((lineIndex - (decimal)LengthOfElements) / CharactersBetweenElements).ToString(CultureInfo.InvariantCulture));
    }

    private static int GetNumberOfElementsIndecimalestLine(IEnumerable<string> input)
    {
        return GetListIndex(input.Max(line => line.Length));
    }

    private static List<Stack<string>> InitializeElementStacks(string[] input)
    {
        var elementStacks = new List<Stack<string>>();
        for (var index = 0; index < GetNumberOfElementsIndecimalestLine(input); index++)
        {
            elementStacks.Add(new Stack<string>());
        }

        return elementStacks;
    }
}