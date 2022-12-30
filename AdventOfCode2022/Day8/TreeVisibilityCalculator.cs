namespace AdventOfCode2022.Day8;

public static class TreeVisibilityCalculator
{
    public static int Calculate(List<List<int>> input)
    {
        var result = 0;
        
        for (var row = 0; row < input.Count; row++)
        {
            for (var column = 0; column < input[row].Count; column++)
            {
                if (IsVisible(input, row, column))
                {
                    result++;
                }
            }
        }

        return result;
    }

    private static bool IsVisible(IReadOnlyList<List<int>> input, int row, int column)
    {
        var selectedTreeHeight = input[row][column];
        var isVisibleFromTop = !Enumerable.Range(0, row).Any(topIndex => input[topIndex][column] >= selectedTreeHeight);
        var isVisibleFromRight =  !Enumerable.Range(column + 1, input[row].Count - column - 1).Any(rightIndex => input[row][rightIndex] >= selectedTreeHeight);
        var isVisibleFromBottom = !Enumerable.Range(row + 1, input.Count - row - 1).Any(bottomIndex => input[bottomIndex][column] >= selectedTreeHeight);
        var isVisibleFromLeft = !Enumerable.Range(0, column).Any(leftIndex => input[row][leftIndex] >= selectedTreeHeight);

        return (isVisibleFromTop || isVisibleFromRight || isVisibleFromBottom || isVisibleFromLeft);
    }
}