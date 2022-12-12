namespace AdventOfCode2022.Day4;

public static class DuplicateRangeCalculator
{
    public static bool IsRangeDuplicated((int bottom, int top) first, (int bottom, int top) second) 
        => first.bottom >= second.bottom && first.top <= second.top 
           || second.bottom >= first.bottom && second.top <= first.top;
}