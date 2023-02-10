using AdventOfCode2022.Utilities;
using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day03;

public class RucksackReorganizationService
{
    private const int PartitionSize = 3;
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

    public int ReassignBadges()
    {
        var groupedStrings = _parsedInput.Partition(PartitionSize);
        return groupedStrings.Sum(SumGroup);
    }

    private static int SumGroup(IReadOnlyList<string> group)
    {
        var commonCharacter = CommonCharacterFinder.Find(group[0], group[1], group[2]);
        return CharacterToIntegerConverter.Convert(commonCharacter);
    }
}