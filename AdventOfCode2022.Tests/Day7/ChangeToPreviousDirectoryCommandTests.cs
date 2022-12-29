using AdventOfCode2022.Day7.Models.Commands;

namespace AdventOfCode2022.Tests.Day7;

public class ChangeToPreviousDirectoryCommandTests
{
    [TestCase("/", "/")]
    [TestCase("/directory/", "/")]
    [TestCase("/directory/a/", "/directory/")]
    public void Changes_to_previous_directory(string currentDirectory, string expectedResult)
    {
        var result = ChangeToPreviousDirectoryCommand.Execute(currentDirectory);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}