namespace AdventOfCode2022.Day3;

public static class CommonCharacterFinder
{
    public static char Find(string compartmentOne, string compartmentTwo)
    {
        return compartmentOne.First(compartmentTwo.Contains);
    }
}