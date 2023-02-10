using System.ComponentModel;
using AdventOfCode2022.Day02.Enums;

namespace AdventOfCode2022.Day02;

public static class PlayerMoveCalculator
{
    public static Moves Calculate(Moves opponentMove, Outcomes outcome)
    {
        return opponentMove switch
        {
            Moves.Rock when outcome == Outcomes.Draw => Moves.Rock,
            Moves.Rock when outcome == Outcomes.Victory => Moves.Paper,
            Moves.Rock when outcome == Outcomes.Loss => Moves.Scissors,
            Moves.Paper when outcome == Outcomes.Draw => Moves.Paper,
            Moves.Paper when outcome == Outcomes.Victory => Moves.Scissors,
            Moves.Paper when outcome == Outcomes.Loss => Moves.Rock,
            Moves.Scissors when outcome == Outcomes.Draw => Moves.Scissors,
            Moves.Scissors when outcome == Outcomes.Victory => Moves.Rock,
            Moves.Scissors when outcome == Outcomes.Loss => Moves.Paper,
            _ => throw new InvalidEnumArgumentException()
        };
    }
}