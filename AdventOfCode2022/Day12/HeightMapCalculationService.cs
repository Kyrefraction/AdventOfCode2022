using AdventOfCode2022.Day12.Models;
using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day12;

public class HeightMapCalculationService
{
    private readonly (HeightMap heightMap, Vertex root, List<Vertex> desinations) _input;
    public HeightMapCalculationService(string filePath, char root, char destination)
    {
        var input = FileReader.ExtractInput(filePath, Environment.NewLine).ToList();
        _input = HeightmapParser.Parse(input, root, destination);
    }

    public int FindFewestSteps()
    {
        var breadthFirstSearch = new BreadthFirstSearch(_input.heightMap, _input.root);
        while (breadthFirstSearch.HasBranchesToSearch())
        {
            var currentVertex = breadthFirstSearch.Search();
            if (_input.desinations.Contains(currentVertex))
            {
                return breadthFirstSearch.GetVertexDistanceFromRoot(currentVertex);
            }
        }

        throw new Exception("No path could be found from root to destination");
    }
}