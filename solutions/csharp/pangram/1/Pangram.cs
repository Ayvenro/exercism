public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var set = new HashSet<char>();
        foreach (char c in input.ToLowerInvariant())
        {
            if (c >= 'a' && c <= 'z')
                set.Add(c);
            if (set.Count == 26)
                return true;
        }
        return false;
    }
}
