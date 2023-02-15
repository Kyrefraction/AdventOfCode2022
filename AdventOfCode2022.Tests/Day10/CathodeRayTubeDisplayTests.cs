using AdventOfCode2022.Day10;

namespace AdventOfCode2022.Tests.Day10;

[TestFixture]
public class CathodeRayTubeDisplayTests
{
    private CathodeRayTubeDisplay _cathodeRayTubeDisplay = null!;

    [SetUp]
    public void SetUp()
    {
        _cathodeRayTubeDisplay = new CathodeRayTubeDisplay();
    }
    
    [Test]
    public void DisplaysSprite()
    {
        var spritePixels = new List<int> { 0, 1, 2 };
        const int cycles = 240;
        for (var index = 1; index <= cycles; index++)
        {
            _cathodeRayTubeDisplay.ExecuteCycle(spritePixels);
        }

        var result = _cathodeRayTubeDisplay.RetrieveDisplay();
        const string expectedResult = 
          @"###.....................................
###.....................................
###.....................................
###.....................................
###.....................................
###.....................................";
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}