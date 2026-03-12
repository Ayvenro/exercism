using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new (identifier);
        sb.Replace(" ", "_");
        sb.Replace("\0", "CTRL");
        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] == '-' && i + 1 < sb.Length)
            {
                sb[i+1] = char.ToUpper(sb[i+1]);
                sb.Remove(i, 1);
                i--;
                continue;
            }
            if (!char.IsLetter(sb[i]) && sb[i] != '_')
            {
                sb.Remove(i, 1);
                i--;
                continue;
            }
            if (sb[i] >= 'α' && sb[i] <= 'ω')
            {
                sb.Remove(i, 1);
                i--;
                continue;
            }
        }
        return sb.ToString();
    }
}
