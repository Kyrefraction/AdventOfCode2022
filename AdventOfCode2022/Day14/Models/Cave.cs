namespace AdventOfCode2022.Day14.Models;

public record Cave(string[,] Tiles, (int x, int y) SourceCoordinates)
{
    public (int x, int y) SpawnSand()
    {
        return DropSand(SourceCoordinates);
    }

    private (int x, int y) DropSand((int x, int y) currentCoordinates)
    {
        if (Tiles[currentCoordinates.x, currentCoordinates.y + 1] == CaveTile.Air)
        {
            return DropSand((currentCoordinates.x, currentCoordinates.y + 1));
        }

        if (Tiles[currentCoordinates.x - 1, currentCoordinates.y + 1] == CaveTile.Air)
        {
            return DropSand((currentCoordinates.x - 1, currentCoordinates.y + 1));
        }
        
        if (Tiles[currentCoordinates.x + 1, currentCoordinates.y + 1] == CaveTile.Air)
        {
            return DropSand((currentCoordinates.x + 1, currentCoordinates.y + 1));
        }

        Tiles[currentCoordinates.x, currentCoordinates.y] = CaveTile.Sand;
        return currentCoordinates;
    }
}