using System.Diagnostics;
using AdventOfCode2022.Day14.Models;
using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day14;

public static class CaveGenerator
{
    private const int FloorDistance = 2;
    public static Cave Generate(List<List<(int x, int y)>> input, (int x, int y) sourceCoordinates)
    {
        var minX = GetMinX(input);
        var maxX = GetMaxX(input) - minX;
        var maxY = GetMaxY(input);

        return GenerateCaveFromRockFormation(minX, maxX, maxY, input, sourceCoordinates);
    }
    
    public static Cave GenerateWithFloor(List<List<(int x, int y)>> input, (int x, int y) sourceCoordinates)
    {
        var maxY = GetMaxY(input) + FloorDistance;
        const int minX = 0;
        var maxX = sourceCoordinates.x + maxY;

        var cave = GenerateCaveFromRockFormation(minX, maxX, maxY, input, sourceCoordinates);
        for (var index = 0; index < maxX; index++)
        {
            cave.Tiles[index, maxY - 1] = CaveTile.Rock;
        }
        return cave;
    }

    private static Cave GenerateCaveFromRockFormation(int minX, int maxX, int maxY, List<List<(int x, int y)>> input, (int x, int y) sourceCoordinates)
    {
        var caveTiles = TwoDimensionalArrayUtilities.InitialiseTwoDimensionalArray(maxX, maxY, CaveTile.Air);
        foreach (var rockFormation in input)
        {
            for (var index = 1; index < rockFormation.Count; index++)
            {
                var distinctXPoints = EnumerableUtilities.Range(rockFormation[index - 1].x, rockFormation[index].x);
                var distinctYPoints = EnumerableUtilities.Range(rockFormation[index - 1].y, rockFormation[index].y);
                var distinctCoordinates = distinctXPoints
                    .SelectMany(x => distinctYPoints
                        .Select(y => (x, y)));

                foreach (var coordinate in distinctCoordinates)
                {
                    caveTiles[coordinate.x - minX, coordinate.y] = CaveTile.Rock;
                }
            }
        }

        caveTiles[sourceCoordinates.x - minX, sourceCoordinates.y] = CaveTile.Source;
        return new Cave(caveTiles, (sourceCoordinates.x - minX, sourceCoordinates.y));
    }
    
    private static int GetMaxY(IEnumerable<List<(int x, int y)>> input)
    {
        return input.Max(rockFormation => rockFormation.Max(rockLine => rockLine.y)) + 1;
    }
    
    private static int GetMinX(IEnumerable<List<(int x, int y)>> input)
    {
        return input.Min(rockFormation => rockFormation.Min(rockLine => rockLine.x));
    }

    private static int GetMaxX(IEnumerable<List<(int x, int y)>> input)
    {
        return input.Max(rockFormation => rockFormation.Max(rockLine => rockLine.x)) + 1;
    }
}