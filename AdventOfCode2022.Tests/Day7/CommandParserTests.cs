using AdventOfCode2022.Day7;
using AdventOfCode2022.Day7.Models.Commands;
using Newtonsoft.Json;

namespace AdventOfCode2022.Tests.Day7;

public class CommandParserTests
{
    [Test]
    public void Parses()
    {
        var input = new List<string>
        {
            "$ cd /",
            "$ ls",
            "dir a",
            "14848514 b.txt",
            "8504156 c.dat",
            "dir d",
            "$ cd a",
            "$ ls",
            "dir e",
            "29116 f",
            "2557 g",
            "62596 h.lst",
            "$ cd e",
            "$ ls",
            "584 i",
            "$ cd ..",
            "$ cd ..",
            "$ cd d",
            "$ ls",
            "4060174 j",
            "8033020 d.log",
            "5626152 d.ext",
            "7214296 k"
        };

        var expectedResult = JsonConvert.SerializeObject(new List<ICommand>
        {
            new ChangeDirectoryCommand("/"),
            new ListCommand(new List<string>
            {
                "dir a",
                "14848514 b.txt",
                "8504156 c.dat",
                "dir d"
            }),
            new ChangeDirectoryCommand("a"),
            new ListCommand(new List<string>
            {
                "dir e",
                "29116 f",
                "2557 g",
                "62596 h.lst"
            }),
            new ChangeDirectoryCommand("e"),
            new ListCommand(new List<string>
            {
                "584 i"
            }),
            new ChangeDirectoryCommand(".."),
            new ChangeDirectoryCommand(".."),
            new ChangeDirectoryCommand("d"),
            new ListCommand(new List<string>
            {
                "4060174 j",
                "8033020 d.log",
                "5626152 d.ext",
                "7214296 k"
            })
        });

        var result = JsonConvert.SerializeObject(CommandParser.Parse(input));
        
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}