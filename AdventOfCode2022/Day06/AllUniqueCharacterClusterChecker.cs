namespace AdventOfCode2022.Day06;

public static class AllUniqueCharacterClusterChecker
{
    public static bool Check(string input)
    {
        var characters = new char[input.Length];

        for (var index = 0; index < input.Length; index++)
        {
            var character = input[index];
            if (characters.Contains(character))
            {
                return false;
            }

            characters[index] = character;
        }

        return true;
    }
}