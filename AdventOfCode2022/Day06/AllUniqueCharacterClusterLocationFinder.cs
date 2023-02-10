namespace AdventOfCode2022.Day06;

public static class AllUniqueCharacterClusterLocationFinder
{
    public static int Find(string input, int markerLength)
    {
        for (var index = 0; index + markerLength < input.Length; index++)
        {
            var characterCluster = input.Substring(index, markerLength);
            if (AllUniqueCharacterClusterChecker.Check(characterCluster))
            {
                return index + markerLength;
            }
        }

        throw new Exception($"No marker could be found in the given input: {input}");
    }
}