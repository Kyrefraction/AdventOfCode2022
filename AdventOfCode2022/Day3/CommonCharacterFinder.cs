namespace AdventOfCode2022.Day3;

public static class CommonCharacterFinder
{
    public static char Find(string first, string second)
    {
        return first.First(second.Contains);
    }
    
    public static char Find(string first, string second, string third)
    {
        return first.First(character => second.Contains(character) && third.Contains(character));
    }
}