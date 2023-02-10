namespace AdventOfCode2022.Day04;

public static class OverlappedRangeCalculator
{
    public static bool IsRangeOverlapped((int bottom, int top) first, (int bottom, int top) second)
    {
        return first.top >= second.bottom && first.bottom <= second.top;
    }
}