using System.ComponentModel;
using AdventOfCode2022.Day02.Enums;

namespace AdventOfCode2022.Day02.Mappers;

public static class MoveMapper
{
    public static Moves Map(string move)
    {
        switch (move)
        {
            case "A":
            case "X":
                return Moves.Rock;
            case "B":
            case "Y":
                return Moves.Paper;
            case "C":
            case "Z":
                return Moves.Scissors;
            default:
                throw new InvalidEnumArgumentException();
        }
    }
}