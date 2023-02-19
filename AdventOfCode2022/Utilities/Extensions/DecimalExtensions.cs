namespace AdventOfCode2022.Utilities.Extensions;

public static class DecimalExtensions
{
    public static int ToInt(this decimal value)
    {
        return Convert.ToInt32(value);
    }
}