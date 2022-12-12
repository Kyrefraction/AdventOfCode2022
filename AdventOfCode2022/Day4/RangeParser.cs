namespace AdventOfCode2022.Day4;

public static class RangeParser
{
    private const string Separator = "-";
    public static (int, int) Parse(string input)
    {
        var values = input.Split(Separator);
        
        return (int.Parse(values[0]), int.Parse(values[1]));
    }
}