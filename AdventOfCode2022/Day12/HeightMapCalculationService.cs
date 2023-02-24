using AdventOfCode2022.Day12.Models;
using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day12;

public class HeightMapCalculationService
{
    private readonly (HeightMap heightMap, List<Vertex> roots, Vertex desination) _input;
    public HeightMapCalculationService(string filePath, char root, char destination)
    {
        var input = FileReader.ExtractInput(filePath, Environment.NewLine).ToList();
        _input = HeightmapParser.Parse(input, root, destination);
    }

    public int FindFewestSteps()
    {
        var shortestPaths = new List<int>();
        foreach (var breadthFirstSearch in _input.roots.Select(root => new BreadthFirstSearch(_input.heightMap, root)))
        {
            while (breadthFirstSearch.HasBranchesToSearch())
            {
                var currentVertex = breadthFirstSearch.Search();
                if (currentVertex == _input.desination)
                {
                    shortestPaths.Add(breadthFirstSearch.GetVertexDistanceFromRoot(currentVertex));
                }
            }
        }

        return shortestPaths.Min();
    }
}