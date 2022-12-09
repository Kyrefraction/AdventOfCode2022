using System.ComponentModel;
using AdventOfCode2022.Day2.Enums;

namespace AdventOfCode2022.Day2.Mappers;

public static class ScoreMapper
{
    private const int VictoryScore = 6;
    private const int DrawScore = 3;
    private const int LossScore = 0;
    public static int MapScore(Outcomes outcomes)
    {
        return outcomes switch
        {
            Outcomes.Victory => VictoryScore,
            Outcomes.Draw => DrawScore,
            Outcomes.Loss => LossScore,
            _ => throw new InvalidEnumArgumentException()
        };
    }
}