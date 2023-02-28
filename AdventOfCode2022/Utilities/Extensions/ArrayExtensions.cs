using System.Text;

namespace AdventOfCode2022.Utilities.Extensions;

public static class ArrayExtensions
{
    public static string ToDisplayString(this string[,] array)
    {
        var stringBuilder = new StringBuilder(string.Empty);
        var maxX = array.GetLength(1);
        var maxY = array.GetLength(0);
        for (var xIndex = 0; xIndex < maxX; xIndex++)
        {
            for (var yIndex = 0; yIndex < maxY; yIndex++)
            {
                stringBuilder.Append($"{array[yIndex, xIndex]}");
            }

            stringBuilder.Append($"{Environment.NewLine}");
        }

        return stringBuilder.ToString();
    }
}