using AdventOfCode2022.Day11;

namespace AdventOfCode2022.Tests.Day11;

[TestFixture]
public class MonkeyTests
{
    private Monkey _monkey = null!;
    private const int Position = 0;
    private static readonly List<int> StartingItems = new() { 79, 98 };
    private static int Operation(int worry) => worry * 19;
    private static bool Test(int worry) => worry % 23 == 0;
    private static readonly (int, int) Destination = (2, 3);
    
    [SetUp]
    public void SetUp()
    {
        _monkey = new Monkey(Position, StartingItems, Operation, Test, Destination);
    }
    
    [Test]
    public void InspectsItems()
    {
        var result = _monkey.InspectItems();
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