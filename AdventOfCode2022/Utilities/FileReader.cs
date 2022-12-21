namespace AdventOfCode2022.Utilities;

public static class FileReader
{
    public static string ExtractInput(string path)
    {
        return File.ReadAllText(path);
    }
    
    public static IEnumerable<string> ExtractInput(string path, string splitValue)
    {
        var file = File.ReadAllText(path);
        return file.Split(splitValue).ToList();
    }
}