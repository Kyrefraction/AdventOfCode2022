using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day8;

public class TreePatchEvaluationService
{
    private readonly List<List<int>> _parsedInput;

    public TreePatchEvaluationService(string filePath)
    {
        var treeLines = FileReader.ExtractInput(filePath, Environment.NewLine);
        _parsedInput = TreePatchParser.Parse(treeLines);
    }

    public int EvaluateNumberOfVisibleTrees()
    {
        return TreeVisibilityCalculator.Calculate(_parsedInput);
    }

    public int EvaluateMaximumScenicScore()
    {
        return TreeScenicScoresCalculator.Calculate(_parsedInput).Max();
    }
}