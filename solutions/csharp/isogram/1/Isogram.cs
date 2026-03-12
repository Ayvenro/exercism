public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var seen = new HashSet<char>();
        foreach (var c in word.ToLowerInvariant())
        {
            if (!char.IsLetter(c))
                continue;
            if (!seen.Add(c))
                return false;
        }
        return true;
    }
}
