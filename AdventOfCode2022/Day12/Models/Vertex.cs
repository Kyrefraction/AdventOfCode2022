namespace AdventOfCode2022.Day12.Models;

public record Vertex ((int x, int y) Coordinates)
{
    public IEnumerable<Vertex> GetNeighbourVertices()
    {
        return new List<Vertex>
        {
            new((Coordinates.x - 1, Coordinates.y)),
            new((Coordinates.x + 1, Coordinates.y)),
            new((Coordinates.x, Coordinates.y - 1)),
            new((Coordinates.x, Coordinates.y + 1)),
        };
    }
}