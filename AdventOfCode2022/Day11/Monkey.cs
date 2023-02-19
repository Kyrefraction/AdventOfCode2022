namespace AdventOfCode2022.Day11;

public class Monkey
{
    private const long DefaultNumberOfInspections = 0;
    private readonly Func<long, long> _operation;
    private readonly int _testDivider;
    private readonly (int @true, int @false) _destination;
    private List<long> _items;
    private long _numberOfInspections;
    public Monkey(List<long> items, Func<long, long> operation, int testDivider, (int @true, int @false) destination)
    {
        _items = items;
        _operation = operation;
        _testDivider = testDivider;
        _destination = destination;
        _numberOfInspections = DefaultNumberOfInspections;
    }

    public List<(long worryLevel, int destination)> InspectItems(long postInspectionWorryDivisor, int leastCommonMultiple)
    {
        var thrownItems = _items.Select(item => InspectItem(item, postInspectionWorryDivisor, leastCommonMultiple)).ToList();
        _items = new List<long>();
        return thrownItems;
    }

    private (long worryLevel, int destination) InspectItem(long item, long postInspectionWorryDivisor, int leastCommonMultiple)
    {
        var inspectionWorryResult = _operation(item);
        _numberOfInspections++;
        var postInspectionWorryResult = (long)Math.Floor(inspectionWorryResult / (decimal)postInspectionWorryDivisor) % leastCommonMultiple;

        var testResult = postInspectionWorryResult % _testDivider == 0;
        var destination = testResult ? _destination.@true : _destination.@false;
        return (postInspectionWorryResult, destination);
    }

    public long NumberOfInspections()
    {
        return _numberOfInspections;
    }

    public List<long> Items()
    {
        return _items;
    }

    public int TestDivider()
    {
        return _testDivider;
    }

    public void ReceiveItem(long item)
    {
        _items.Add(item);
    }
}