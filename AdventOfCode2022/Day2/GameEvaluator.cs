using AdventOfCode2022.Day2.Mappers;
using AdventOfCode2022.Utilities;

namespace AdventOfCode2022.Day2;

public class GameEvaluator
{
    private readonly IEnumerable<(string, string)> _parsedInputs;

    public GameEvaluator(string filePath)
    {
        var input = FileReader.ExtractInput(filePath, Environment.NewLine);
        _parsedInputs = Parser.Parse(input);
    }
    
    public int CalculatePlayerScore()
    {
        var playerScore = _parsedInputs.Sum(parsedInput => RoundEvaluator.Evaluate(MoveMapper.Map(parsedInput.Item1), MoveMapper.Map(parsedInput.Item2)));
        return playerScore;
    }
    
    public int CalculatePlayerScoreWithSecondColumnAsOutcome()
    {
        var playerScore = _parsedInputs.Sum(parsedInput => RoundEvaluator.Evaluate(MoveMapper.Map(parsedInput.Item1), OutcomeMapper.Map(parsedInput.Item2)));
        return playerScore;
    }
}