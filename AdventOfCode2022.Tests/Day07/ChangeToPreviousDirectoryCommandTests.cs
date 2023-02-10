using AdventOfCode2022.Day07.Models.Commands;

namespace AdventOfCode2022.Tests.Day07;

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