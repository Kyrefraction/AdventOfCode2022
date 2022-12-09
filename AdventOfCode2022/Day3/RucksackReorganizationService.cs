using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day3;

public class RucksackReorganizationService
{
    private readonly IEnumerable<string> _parsedInput;
    public RucksackReorganizationService(string filePath)
    {
        _parsedInput = FileReader.ExtractInput(filePath, Environment.NewLine);
    }

    public int Reorganize()
    {
        var halvedStrings = _parsedInput.Select(StringDivider.Half);
        var commonCharacters = halvedStrings.Select(halvedString => CommonCharacterFinder.Find(halvedString.Item1, halvedString.Item2));
        var commonCharacterIntegerValues = commonCharacters.Select(CharacterToIntegerConverter.Convert);
        return commonCharacterIntegerValues.Sum();
    }
}