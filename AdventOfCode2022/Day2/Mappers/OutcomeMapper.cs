using System.ComponentModel;
using AdventOfCode2022.Day2.Enums;

namespace AdventOfCode2022.Day2.Mappers;

public static class OutcomeMapper
{
    public static Outcomes Map(string outcome)
    {
        return outcome switch
        {
            "X" => Outcomes.Loss,
            "Y" => Outcomes.Draw,
            "Z" => Outcomes.Victory,
            _ => throw new InvalidEnumArgumentException()
        };
    }
}