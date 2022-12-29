using AdventOfCode2022.Day7.Models.Commands;

namespace AdventOfCode2022.Tests.Day7;

public class ChangeToSpecificDirectoryCommandTests
{
    [TestCase("/", "a", "/a/")]
    [TestCase("/a/", "bcd", "/a/bcd/")]
    public void Changes_to_specific_directory(string currentDirectory, string targetDirectory, string expectedResult)
    {
        var result = ChangeToSpecificDirectoryCommand.Execute(currentDirectory, targetDirectory);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}