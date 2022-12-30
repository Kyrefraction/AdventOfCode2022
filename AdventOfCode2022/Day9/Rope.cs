using AdventOfCode2022.Day9.Enums;

namespace AdventOfCode2022.Day9;

public class Rope
{
    private static readonly (int x, int y) StartPosition = (0, 0);
    private readonly HashSet<(int x, int y)> _tailPositionHistory;
    private (int x, int y) _head;
    private (int x, int y) _tail;

    public Rope()
    {
        _head = StartPosition;
        _tail = StartPosition;
        _tailPositionHistory = new HashSet<(int, int)> { StartPosition };
    }
    
    public HashSet<(int, int)> GetTailPositionHistory()
    {
        return _tailPositionHistory;
    }

    public void Move(IEnumerable<(Direction, int)> moves)
    {
        foreach (var (direction, distance) in moves)
        {
            for (var index = 0; index < distance; index++)
            {
                Move(direction);
            }
        }
    }

    private void Move(Direction direction)
    {
        MoveHead(direction);
        MoveTail();
        RecordTailPosition();
    }

    private void RecordTailPosition()
    {
        _tailPositionHistory.Add(_tail);
    }

    private void MoveHead(Direction direction)
    {
        (_head.x, _head.y) = direction switch
        {
            Direction.Up => (_head.x, _head.y + 1),
            Direction.Right => (_head.x + 1, _head.y),
            Direction.Down => (_head.x, _head.y - 1),
            Direction.Left => (_head.x - 1, _head.y),
            _ => throw new ArgumentOutOfRangeException($"Unexpected direction: {direction}")
        };
    }
    
    private void MoveTail()
    {
        if (IsAdjacent()) return;
        
        if (_head.x > _tail.x) _tail.x++;
        if (_head.x < _tail.x) _tail.x--;
            
        if (_head.y > _tail.y) _tail.y++;
        if (_head.y < _tail.y) _tail.y--;
    }
    
    private bool IsAdjacent() => !(Math.Max(Math.Abs(_head.x - _tail.x), Math.Abs(_head.y - _tail.y)) > 1);
}