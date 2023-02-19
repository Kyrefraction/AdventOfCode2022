using AdventOfCode2022.Day11;

namespace AdventOfCode2022.Tests.Day11;

[TestFixture]
public class MonkeyTests
{
    private const long PostInspectionWorryDivisor = 3;
    private const int Test = 23;
    private static readonly List<long> StartingItems = new() { 79, 98 };
    private static readonly (int, int) Destination = (2, 3);
    private Monkey _monkey = null!;
    private static long Operation(long worry) => worry * 19;
    
    [SetUp]
    public void SetUp()
    {
        _monkey = new Monkey(StartingItems, Operation, Test, Destination);
    }
    
    [Test]
    public void InspectsItems()
    {
        var result = _monkey.InspectItems(PostInspectionWorryDivisor, 7742);
        var expectedResult = new List<(int, int)>
        {
            (500, 3),
            (620, 3)
        };

        const int expectedNumberOfInspections = 2;
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(expectedResult));
            Assert.That(_monkey.NumberOfInspections(), Is.EqualTo(expectedNumberOfInspections));
        });
    }

    [Test]
    public void ReceivesItem()
    {
        _monkey.ReceiveItem(100);
        const int expectedNumberOfItems = 3;
        Assert.That(_monkey.Items(), Has.Count.EqualTo(expectedNumberOfItems));
    }
}