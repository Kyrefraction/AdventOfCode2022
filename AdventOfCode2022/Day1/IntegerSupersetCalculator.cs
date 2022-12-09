namespace AdventOfCode2022.Day1;

public static class IntegerSupersetCalculator
{
    public static int CalculateGreatestFlattenedSetTotals(IEnumerable<IEnumerable<int>> superset, int numberOfSets)
    {
        var summedValues = superset.Select(set => set.Sum());
        return summedValues.OrderByDescending(value => value).Take(numberOfSets).Sum();
    }
}