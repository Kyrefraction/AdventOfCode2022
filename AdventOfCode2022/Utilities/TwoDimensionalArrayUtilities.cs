namespace AdventOfCode2022.Utilities;

public static class TwoDimensionalArrayUtilities
{
    public static T[,] InitialiseTwoDimensionalArray<T>(int x, int y, T defaultValue)
    {
        var array = new T[x, y];
        for (var i = 0; i < x * y; i++)
        {
            array[i % x, i / x] = defaultValue;
        }
        
        return array;
    }
}