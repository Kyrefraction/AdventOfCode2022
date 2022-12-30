namespace AdventOfCode2022.Utilities.Extensions;

public static class CharExtensions
{
    public static int ToInt(this char input)
    {
        return int.Parse(input.ToString());
    }
}