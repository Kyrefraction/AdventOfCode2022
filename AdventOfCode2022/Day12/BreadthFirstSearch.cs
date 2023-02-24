using AdventOfCode2022.Day12.Models;

namespace AdventOfCode2022.Day12;

public class BreadthFirstSearch
{
    private const int NotExploredDistance = int.MaxValue;
    private const int DistanceBetweenVertices = 1;
    private readonly HeightMap _heightMap;
    private readonly Queue<Vertex> _searchQueue = new();
    private readonly int[,] _distances;

    public BreadthFirstSearch(HeightMap heightMap, Vertex root)
    {
        _heightMap = heightMap;
        _distances = new int[heightMap.MaxX, heightMap.MaxY];

        for (var xIndex = 0; xIndex < heightMap.MaxX; xIndex++)
        {
            for (var yIndex = 0; yIndex < heightMap.MaxY; yIndex++)
            {
                _distances[xIndex, yIndex] = NotExploredDistance;
            }
        }

        _distances[root.Coordinates.x, root.Coordinates.y] = 0;
        _searchQueue.Enqueue(root);
    }

    public int GetVertexDistanceFromRoot(Vertex vertex)
    {
        return _distances[vertex.Coordinates.x, vertex.Coordinates.y];
    }

    public bool HasBranchesToSearch()
    {
        return _searchQueue.Any();
    }

    public Vertex Search()
    {
        var vertex = _searchQueue.Dequeue();
        foreach (var neighbour in _heightMap.FindAccessibleNeighbours(vertex).Where(neighbour => _distances[neighbour.Coordinates.x, neighbour.Coordinates.y] == NotExploredDistance))
        {
            _distances[neighbour.Coordinates.x, neighbour.Coordinates.y] = _distances[vertex.Coordinates.x, vertex.Coordinates.y] + DistanceBetweenVertices;
            _searchQueue.Enqueue(neighbour);
        }

        return vertex;
    }
}