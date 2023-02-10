using AdventOfCode2022.Day07.Models;
using AdventOfCode2022.Day07.Models.Commands;
using Newtonsoft.Json;
using File = AdventOfCode2022.Day07.Models.File;

namespace AdventOfCode2022.Tests.Day07;

public class FileSystemConstructorTests
{
    [Test]
    public void Constructs_file_system()
    {
        var commands = new List<ICommand>
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
        };

        var expectedResult = new Dictionary<string, List<File>>
        {
            {
                "/",
                new List<File>
                {
                    new("b.txt", 14848514),
                    new("c.dat", 8504156)
                }
            },
            {
                "/a/",
                new List<File>
                {
                    new("f", 29116),
                    new("g", 2557),
                    new("h.lst", 62596)
                }
            },
            {
                "/d/",
                new List<File>
                {
                    new("j", 4060174),
                    new("d.log", 8033020),
                    new("d.ext", 5626152),
                    new("k", 7214296)
                }
            },
            {
                "/a/e/",
                new List<File>
                {
                    new("i", 584)
                }
            }
        };

        var result = FileSystem.FromCommands(commands);

        Assert.That(JsonConvert.SerializeObject(result), Is.EqualTo(JsonConvert.SerializeObject(expectedResult)));
    }
}