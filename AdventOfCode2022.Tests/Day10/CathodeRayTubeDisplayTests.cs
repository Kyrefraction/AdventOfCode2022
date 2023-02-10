using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Tests.Day10;

[TestFixture]
public class CathodeRayTubeDisplayTests
{
    private CathodeRayTubeDisplay _cathodeRayTubeDisplay;

    [SetUp]
    public void SetUp()
    {
        _cathodeRayTubeDisplay = new CathodeRayTubeDisplay();
    }
    
    [Test]
    public void DisplaysSprite()
    {
        var spritePixels = new List<int> { 1, 2, 3 };
        const int cycles = 240;
        for (var index = 1; index <= cycles; index++)
        {
            _cathodeRayTubeDisplay.ExecuteCycle(spritePixels);
        }

        var result = _cathodeRayTubeDisplay.DrawDisplay();
        const string expectedResult = @"###.....................................
........................................
........................................
........................................
........................................
........................................";
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}

public class CathodeRayTubeDisplay
{
    private const int LineLength = 40;
    private string _display;
    private int _cycle;
    public CathodeRayTubeDisplay()
    {
        _cycle = 1;
        _display = string.Empty;
    }

    public void ExecuteCycle(List<int> spritePixels)
    {
        if (spritePixels.Contains(_cycle))
        {
            _display += "#";
        }
        else
        {
            _display += ".";
        }

        _cycle++;
    }

    public string DrawDisplay()
    {
        return string.Join(Environment.NewLine, _display.SpliceText(LineLength));
    }
}