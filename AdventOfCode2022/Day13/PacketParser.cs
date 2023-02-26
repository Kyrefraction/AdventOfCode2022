using System.Text.Json;
using AdventOfCode2022.Day13.Models;

namespace AdventOfCode2022.Day13;

public static class PacketParser
{
    public static List<(IPacket left, IPacket right)> Parse(IEnumerable<string> input)
    {
        return input
            .Select(pairs => pairs.Split(Environment.NewLine))
            .Select(pair => (
                Parse(pair.First()),
                Parse(pair.Last())
                ))
            .ToList();
    }

    private static IPacket Parse(string line)
    {
        var element = JsonSerializer.Deserialize<JsonElement>(line);
        return Parse(element);
    }

    private static IPacket Parse(JsonElement element)
    {
        return element.ValueKind switch
        {
            JsonValueKind.Number => new IntegerPacket(element.GetInt32()),
            JsonValueKind.Array => new ListPacket(element.EnumerateArray().Select(Parse).ToList()),
            _ => throw new ArgumentOutOfRangeException(nameof(element), "Unsupported element type")
        };
    }
}