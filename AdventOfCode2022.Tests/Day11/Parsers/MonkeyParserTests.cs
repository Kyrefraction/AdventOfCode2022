using AdventOfCode2022.Day11;
using AdventOfCode2022.Day11.Parsers;

namespace AdventOfCode2022.Tests.Day11.Parsers;

[TestFixture]
public class MonkeyParserTests
{
    [Test]
    public void Parses()
    {
        var input = new List<string>
        {
            @"Monkey 0:
            Starting items: 79, 98
            Operation: new = old * 19
            Test: divisible by 23
            If true: throw to monkey 2
            If false: throw to monkey 3",

            @"Monkey 1:
            Starting items: 54, 65, 75, 74
            Operation: new = old + 6
            Test: divisible by 19
            If true: throw to monkey 2
            If false: throw to monkey 0",

            @"Monkey 2:
            Starting items: 79, 60, 97
            Operation: new = old * old
            Test: divisible by 13
            If true: throw to monkey 1
            If false: throw to monkey 3",

            @"Monkey 3:
            Starting items: 74
            Operation: new = old + 3
            Test: divisible by 17
            If true: throw to monkey 0
            If false: throw to monkey 1"
        };

        var expectedResult = new List<Monkey>
        {
            new(new List<long> { 79, 98 }, worry => worry * 19, 3, (2, 3)),
            new(new List<long> { 54, 65, 75, 74 }, worry => worry + 6, 19, (2, 0)),
            new(new List<long> { 79, 60, 97 }, worry => worry * worry, 13, (1, 3)),
            new(new List<long> { 74 }, worry => worry + 3, 17, (0, 1))
        };

        var result = MonkeyParser.Parse(input);
        
        Assert.That(result.ToString(), Is.EqualTo(expectedResult.ToString()));
    }
}