using AdventOfCode2022.Day12.Models;

namespace AdventOfCode2022.Day12;

public record HeightMap(int[,] Heights)
{
    private const int MaximumAccessibleHeightDifference = 1;
    public readonly int MaxX = Heights.GetLength(0);
    public readonly int MaxY = Heights.GetLength(1);

    public IEnumerable<Vertex> FindAccessibleNeighbours(Vertex vertex)
    {
        return vertex.GetNeighbourVertices().Where(neighbourVertex => IsAccessible(vertex, neighbourVertex)).ToList();
    }

    private bool IsAccessible(Vertex vertex, Vertex neighbourVertex)
    {
        if (!IsOnGrid(vertex) || !IsOnGrid(neighbourVertex))
        {
            return false;
        }

        var vertexHeight = Heights[vertex.Coordinates.x, vertex.Coordinates.y];
        var neighbourVertexHeight = Heights[neighbourVertex.Coordinates.x, neighbourVertex.Coordinates.y];

        return neighbourVertexHeight >= vertexHeight - MaximumAccessibleHeightDifference;
    }

    private bool IsOnGrid(Vertex vertex)
    {
        return vertex.Coordinates is { x: >= 0, y: >= 0 } && 
               vertex.Coordinates.x < MaxX &&
               vertex.Coordinates.y < MaxY;
    }
}