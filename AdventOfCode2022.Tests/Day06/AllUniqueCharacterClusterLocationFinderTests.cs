using AdventOfCode2022.Day06;

namespace AdventOfCode2022.Tests.Day06;

public class AllUniqueCharacterClusterLocationFinderTests
{
    [TestCase("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 4, 7)]
    [TestCase("bvwbjplbgvbhsrlpgdmjqwftvncz", 4,5)]
    [TestCase("nppdvjthqldpwncqszvftbrmjlhg", 4,6)]
    [TestCase("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 4,10)]
    [TestCase("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 4,11)]
    [TestCase("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 14, 19)]
    [TestCase("bvwbjplbgvbhsrlpgdmjqwftvncz", 14,23)]
    [TestCase("nppdvjthqldpwncqszvftbrmjlhg", 14,23)]
    [TestCase("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 14,29)]
    [TestCase("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 14,26)]
    public void Finds(string input, int markerLength, int expectedResult)
    {
        var result = AllUniqueCharacterClusterLocationFinder.Find(input, markerLength);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}