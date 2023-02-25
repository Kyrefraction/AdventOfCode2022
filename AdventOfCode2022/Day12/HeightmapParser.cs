using AdventOfCode2022.Day12.Models;

namespace AdventOfCode2022.Day12;

public static class HeightmapParser
{
    private static readonly Dictionary<char, int> AlphabetDictionary = new()
    {
        { 'a', 1 },
        { 'b', 2 },
        { 'c', 3 },
        { 'd', 4 },
        { 'e', 5 },
        { 'f', 6 },
        { 'g', 7 },
        { 'h', 8 },
        { 'i', 9 },
        { 'j', 10 },
        { 'k', 11 },
        { 'l', 12 },
        { 'm', 13 },
        { 'n', 14 },
        { 'o', 15 },
        { 'p', 16 },
        { 'q', 17 },
        { 'r', 18 },
        { 's', 19 },
        { 't', 20 },
        { 'u', 21 },
        { 'v', 22 },
        { 'w', 23 },
        { 'x', 24 },
        { 'y', 25 },
        { 'z', 26 },
        { 'S', 1 },
        { 'E', 26 }
    };
    public static (HeightMap heightMap, Vertex root, List<Vertex> destinations) Parse(List<string> input, char rootCharacter, char destinationCharacter)
    {
        var heights = new int[input.Count, input.First().Length];
        var root = new Vertex((0, 0));
        var destinations = new List<Vertex>();
        for (var xIndex = 0; xIndex < input.Count; xIndex++)
        {
            for (var yIndex = 0; yIndex < input.First().Length; yIndex++)
            {
                var character = input[xIndex][yIndex];
                if (character == rootCharacter)
                {
                    root = new Vertex((xIndex, yIndex));

                } else if (character == destinationCharacter)
                {
                    destinations.Add(new Vertex((xIndex, yIndex)));
                }
                
                heights[xIndex, yIndex] = AlphabetDictionary[character];
            }
        }

        return (new HeightMap(heights), root, destinations);
    }
}