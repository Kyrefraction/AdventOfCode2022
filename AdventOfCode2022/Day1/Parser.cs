namespace AdventOfCode2022.Day1;

public static class ElfSnackCalorieParser
{
    private static readonly string Splitter = Environment.NewLine;

    public static IEnumerable<IEnumerable<int>> Parse(IEnumerable<string> input)
    {
        return input.Select(ParseElfCalories);
    }

    private static IEnumerable<int> ParseElfCalories(string elf)
    {
        return elf.Split(Splitter).Select(int.Parse);
    }
}