using AdventOfCode2022.Utilities.Extensions;

namespace AdventOfCode2022.Day11;

public class Monkey
{
    private const decimal PostInspectionWorryDivisor = 3m;
    private const int DefaultNumberOfInspections = 0;
    private readonly int _position;
    private List<int> _items;
    private readonly Func<int, int> _operation;
    private readonly Func<int, bool> _test;
    private readonly (int @true, int @false) _destination;
    private int _numberOfInspections;
    public Monkey(int position, List<int> items, Func<int, int> operation, Func<int, bool> test, (int @true, int @false) destination)
    {
        _position = position;
        _items = items;
        _operation = operation;
        _test = test;
        _destination = destination;
        _numberOfInspections = DefaultNumberOfInspections;
    }

    public List<(int worryLevel, int destination)> InspectItems()
    {
        var thrownItems = _items.Select(InspectItem).ToList();
        _items = new List<int>();
        return thrownItems;
    }

    private (int worryLevel, int destination) InspectItem(int item)
    {
        var inspectionWorryResult = _operation(item);
        _numberOfInspections++;
        var postInspectionWorryResult = Math.Floor(inspectionWorryResult / PostInspectionWorryDivisor).ToInt();

        var testResult = _test(postInspectionWorryResult);
        var destination = testResult ? _destination.@true : _destination.@false;
        return (postInspectionWorryResult, destination);
    }

    public int NumberOfInspections()
    {
        return _numberOfInspections;
    }

    public int Position()
    {
        return _position;
    }

    public List<int> Items()
    {
        return _items;
    }

    public void ReceiveItem(int item)
    {
        _items.Add(item);
    }
    
}