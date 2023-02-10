using System.ComponentModel;
using AdventOfCode2022.Day02.Enums;

namespace AdventOfCode2022.Day02.Mappers;

public static class MoveScoreMapper
{
    public static int Map(Moves move)
    {
        return move switch
        {
            Moves.Rock => 1,
            Moves.Paper => 2,
            Moves.Scissors => 3,
            _ => throw new InvalidEnumArgumentException()
        };
    }
}