using AdventOfCode2022.Day02.Enums;
using AdventOfCode2022.Day02.Mappers;

namespace AdventOfCode2022.Day02;

public static class RoundEvaluator
{
    public static int Evaluate(Moves opponentMove, Moves playerMove)
    {
        var moveScore = MoveScoreMapper.Map(playerMove);
        
        var outcome = OutcomeCalculator.Calculate(opponentMove, playerMove);
        var outcomeScore = OutcomeScoreMapper.Map(outcome);

        return moveScore + outcomeScore;
    }
    
    public static int Evaluate(Moves opponentMove, Outcomes outcome)
    {
        var playerMove = PlayerMoveCalculator.Calculate(opponentMove, outcome);
        var moveScore = MoveScoreMapper.Map(playerMove);
        
        var outcomeScore = OutcomeScoreMapper.Map(outcome);

        return moveScore + outcomeScore;
    }
}