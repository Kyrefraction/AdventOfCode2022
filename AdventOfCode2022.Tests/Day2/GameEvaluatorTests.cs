using AdventOfCode2022.Day2;

namespace AdventOfCode2022.Tests.Day2;

public class GameEvaluatorTests
{
    private GameEvaluator _gameEvaluator = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _gameEvaluator = new GameEvaluator("Day2/Resources/input.txt");
    }
    
    [Test]
    public void CalculatesScore()
    {
        var result = _gameEvaluator.CalculatePlayerScore();
        
        Console.WriteLine($"The final player score from the game of rock papers scissors was {result}");
        const int expected = 11150;
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CalculatesScoreWithSecondColumnAsOutcome()
    {
        var result = _gameEvaluator.CalculatePlayerScoreWithSecondColumnAsOutcome();
        
        Console.WriteLine($"The final player score from the game of rock paper scissors was {result}");
        const int expected = 8295;
        Assert.That(result, Is.EqualTo(expected));
    }
}