using AdventOfCode2022.Day2.Enums;
using AdventOfCode2022.Day2.Mappers;

namespace AdventOfCode2022.Day2;

public static class RoundEvaluator
{
    private static readonly Dictionary<Moves, int> MoveScoreMatrix = new()
    {
        [Moves.Rock] = 1,
        [Moves.Paper] = 2,
        [Moves.Scissors] = 3
    };
    
    public static int Evaluate(Moves opponentMove, Moves playerMove)
    {
        var moveScore = MoveScoreMatrix[playerMove];
        
        var outcome = OutcomeCalculator.Calculate(opponentMove, playerMove);
        var outcomeScore = ScoreMapper.MapScore(outcome);

        return moveScore + outcomeScore;
    }
    
    public static int Evaluate(Moves opponentMove, Outcomes outcome)
    {
        var playerMove = PlayerMoveCalculator.Calculate(opponentMove, outcome);
        var moveScore = MoveScoreMatrix[playerMove];
        
        var outcomeScore = ScoreMapper.MapScore(outcome);

        return moveScore + outcomeScore;
    }
}