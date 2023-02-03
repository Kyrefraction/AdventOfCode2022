namespace AdventOfCode2022.Day10.Commands;

public interface ICommand
{
    (List<(int, int)> readings, int cycle, int register) Execute(int cycle, int register);
}