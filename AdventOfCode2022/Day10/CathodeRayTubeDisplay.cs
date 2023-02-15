using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day10;

public class CathodeRayTubeDisplay
{
    private const int LineLength = 40;
    private const int Lines = 6;
    private const string SpriteMarker = "#";
    private const string NonSpriteMarker = ".";
    private string _display;
    private int _cycle;
    public CathodeRayTubeDisplay()
    {
        _cycle = 0;
        _display = string.Empty;
    }

    public void ExecuteCycle(List<int> spritePixels)
    {
        spritePixels = SetSpriteToLine(spritePixels);

        if (SpriteOverlapsCycle(spritePixels))
            _display += SpriteMarker;
        else
            _display += NonSpriteMarker;

        _cycle++;
    }

    private bool SpriteOverlapsCycle(ICollection<int> spritePixels)
    {
        return spritePixels.Contains(_cycle);
    }

    private List<int> SetSpriteToLine(List<int> spritePixels)
    {
        for (var index = 1; index <= Lines; index++)
        {
            if (_cycle > LineLength * index - 1 && _cycle <= LineLength * (index + 1) - 1)
            {
                return spritePixels.Select(spritePixel => spritePixel + index * LineLength).ToList();
            }
        }

        return spritePixels;
    }

    public string RetrieveDisplay()
    {
        return string.Join(Environment.NewLine, _display.SpliceText(LineLength));
    }
}