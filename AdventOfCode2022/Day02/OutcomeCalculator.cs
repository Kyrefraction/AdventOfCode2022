using System.ComponentModel;
using AdventOfCode2022.Day02.Enums;

namespace AdventOfCode2022.Day02;

public static class OutcomeCalculator
{
    public static Outcomes Calculate(Moves opponentMove, Moves playerMove)
    {
        return playerMove switch
        {
            Moves.Rock when opponentMove == Moves.Rock => Outcomes.Draw,
            Moves.Rock when opponentMove == Moves.Paper => Outcomes.Loss,
            Moves.Rock when opponentMove == Moves.Scissors => Outcomes.Victory,
            Moves.Paper when opponentMove == Moves.Rock => Outcomes.Victory,
            Moves.Paper when opponentMove == Moves.Paper => Outcomes.Draw,
            Moves.Paper when opponentMove == Moves.Scissors => Outcomes.Loss,
            Moves.Scissors when opponentMove == Moves.Rock => Outcomes.Loss,
            Moves.Scissors when opponentMove == Moves.Paper => Outcomes.Victory,
            Moves.Scissors when opponentMove == Moves.Scissors => Outcomes.Draw,
            _ => throw new InvalidEnumArgumentException()
        };
    }
    
}