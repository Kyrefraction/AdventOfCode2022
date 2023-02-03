using AdventOfCode2022.Day9.Enums;

namespace AdventOfCode2022.Day9;

public class Rope
{
    private static readonly (int x, int y) StartPosition = (0, 0);
    private static bool IsAdjacent((int x, int y) first, (int x, int y) second) => !(Math.Max(Math.Abs(first.x - second.x), Math.Abs(first.y - second.y)) > 1);
    private readonly HashSet<(int x, int y)> _tailPositionHistory;
    private readonly List<(int x, int y)> _knots;
    private (int x, int y) Tail() => _knots.Last();
    private (int x, int y) Head() => _knots.First();

    public Rope(int knotQuantity)
    {
        _knots = Enumerable.Range(1, knotQuantity).Select(_ => StartPosition).ToList();
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
        UpdateKnots();
        RecordTailPosition();
    }

    private void RecordTailPosition()
    {
        _tailPositionHistory.Add(Tail());
    }

    private void MoveHead(Direction direction)
    {
        _knots[0] = direction switch
        {
            Direction.Up => (Head().x, Head().y + 1),
            Direction.Right => (Head().x + 1, Head().y),
            Direction.Down => (Head().x, Head().y - 1),
            Direction.Left => (Head().x - 1, Head().y),
            _ => throw new ArgumentOutOfRangeException($"Unexpected direction: {direction}")
        };
    }
    
    private void UpdateKnots()
    {
        for (var index = 1; index < _knots.Count; index++)
        {
            var first = _knots[index - 1];
            var second = _knots[index];
            
            if (IsAdjacent(first, second))
                return;
            
            var xDisplacement = 0;
            var yDisplacement = 0;

            if (first.x > second.x)
                xDisplacement += 1;

            if (first.x < second.x)
                xDisplacement -= 1;

            if (first.y > second.y)
                yDisplacement += 1;

            if (first.y < second.y)
                yDisplacement -= 1;

            _knots[index] = (second.x + xDisplacement, second.y + yDisplacement);
        }
    }
}