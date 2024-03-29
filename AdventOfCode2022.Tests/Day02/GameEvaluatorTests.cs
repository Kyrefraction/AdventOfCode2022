﻿using AdventOfCode2022.Day02;

namespace AdventOfCode2022.Tests.Day02;

public class GameEvaluatorTests
{
    private GameEvaluator _gameEvaluator = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _gameEvaluator = new GameEvaluator("Day02/Resources/input.txt");
    }
    
    [Test]
    public void Calculates_score()
    {
        var result = _gameEvaluator.CalculatePlayerScore();
        
        Console.WriteLine($"The final player score from the game of rock papers scissors was {result}");
        const int expected = 11150;
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Calculates_Score_with_second_column_as_outcome()
    {
        var result = _gameEvaluator.CalculatePlayerScoreWithSecondColumnAsOutcome();
        
        Console.WriteLine($"The final player score from the game of rock paper scissors was {result}");
        const int expected = 8295;
        Assert.That(result, Is.EqualTo(expected));
    }
}