namespace AdventOfCode2022.Utilities.Extensions;

public static class DictionaryExtensions
{
    public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IDictionary<TKey, TValue> dictionaryToAdd)
    {
        foreach (var entry in dictionaryToAdd)
        {
            dictionary.Add(entry.Key, entry.Value);
        }
    }
    
    public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IEnumerable<KeyValuePair<TKey, TValue>> listToAdd)
    {
        foreach (var entry in listToAdd)
        {
            dictionary.Add(entry.Key, entry.Value);
        }
    }
}