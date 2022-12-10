using AdventOfCode2022.Day2;
using AdventOfCode2022.Day2.Mappers;

namespace AdventOfCode2022.Tests.Day2;

public class RoundEvaluatorTests
{
    [TestCase("A", "Y", 8)]
    [TestCase("B", "X", 1)]
    [TestCase("C", "Z", 6)]
    public void Evaluates_round(string opponent, string player, int expectedResult)
    {
        var opponentMove = MoveMapper.Map(opponent);
        var playerMove = MoveMapper.Map(player);
        
        var result = RoundEvaluator.Evaluate(opponentMove, playerMove);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [TestCase("A", "Y", 4)]
    [TestCase("B", "X", 1)]
    [TestCase("C", "Z", 7)]
    public void Evaluates_round_with_predestined_outcome(string opponent, string outcome, int expectedResult)
    {
        var opponentMove = MoveMapper.Map(opponent);
        var outcomeResult = OutcomeMapper.Map(outcome);

        var result = RoundEvaluator.Evaluate(opponentMove, outcomeResult);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}