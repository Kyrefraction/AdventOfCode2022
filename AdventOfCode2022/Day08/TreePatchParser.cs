using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day08;

public static class TreePatchParser
{
    public static List<List<int>> Parse(IEnumerable<string> treeLines)
    {
        return treeLines.Select(treeLine => treeLine.Select(character => character.ToInt()).ToList()).ToList();
    }
}