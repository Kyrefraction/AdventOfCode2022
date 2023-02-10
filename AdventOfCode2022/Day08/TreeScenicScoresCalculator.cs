namespace AdventOfCode2022.Day08;

public static class TreeScenicScoresCalculator
{
    public static IEnumerable<int> Calculate(List<List<int>> input)
    {
        var scenicScores = new List<int>();
        for (var row = 0; row < input.Count; row++)
        {
            for (var column = 0; column < input[row].Count; column++)
            {
                var treesVisibleTop = CalculateNumberOfVisibleTopTrees(input, row, column);
                var treesVisibleRight = CalculateNumberOfVisibleRightTrees(input, row, column);
                var treesVisibleBottom = CalculateNumberOfVisibleBottomTrees(input, row, column);
                var treesVisibleLeft = CalculateNumberOfVisibleLeftTrees(input, row, column);

                scenicScores.Add(treesVisibleTop *  treesVisibleRight * treesVisibleBottom * treesVisibleLeft);
            }
        }

        return scenicScores;
    }

    private static int CalculateNumberOfVisibleTopTrees(IReadOnlyList<List<int>> input, int row, int column)
    {
        var topTrees = input.Take(row).Select(tree => tree[column]).ToList();
        var topBlockingTreePosition = topTrees.FindLastIndex(topTreeHeight => topTreeHeight >= input[row][column]);
        return topBlockingTreePosition == -1 ? topTrees.Count : row - topBlockingTreePosition;
    }
    
    private static int CalculateNumberOfVisibleRightTrees(IReadOnlyList<List<int>> input, int row, int column)
    {
        var rightTrees = input[row].Skip(column + 1).Take(input[row].Count - column - 1).Reverse().ToList();
        var rightBlockingTreePosition = rightTrees.FindLastIndex(rightTreeHeight => rightTreeHeight >= input[row][column]);
        return rightBlockingTreePosition == -1 ? rightTrees.Count : input[row].Count - column - rightBlockingTreePosition - 1;
    }
    
    private static int CalculateNumberOfVisibleBottomTrees(IReadOnlyList<List<int>> input, int row, int column)
    {
        var bottomTrees = input.Skip(row + 1).Take(input.Count - row - 1).Select(ints => ints[column]).Reverse().ToList();
        var bottomBlockingTreePosition = bottomTrees.FindLastIndex(bottomTreeHeight => bottomTreeHeight >= input[row][column]);
        return bottomBlockingTreePosition == -1 ? bottomTrees.Count : input.Count - row - bottomBlockingTreePosition - 1;
    }
    
    private static int CalculateNumberOfVisibleLeftTrees(IReadOnlyList<List<int>> input, int row, int column)
    {
        var leftTrees = input[row].Take(column).ToList();
        var leftBlockingTreePosition = leftTrees.FindLastIndex(leftTreeHeight => leftTreeHeight >= input[row][column]);
        return leftBlockingTreePosition == -1 ? leftTrees.Count : column - leftBlockingTreePosition;
    }
}