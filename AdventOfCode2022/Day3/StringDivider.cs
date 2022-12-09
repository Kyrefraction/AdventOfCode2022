namespace AdventOfCode2022.Day3;

public static class StringDivider
{
    public static (string, string) Half(string input)
    {
        var firstHalf =  input[0 .. (input.Length / 2)];
        var secondHalf = input[(input.Length / 2) .. input.Length];

        return (firstHalf, secondHalf);
    }
}