using System.Text;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        if (string.IsNullOrWhiteSpace(phrase))
            return string.Empty;
        var acronymBuilder = new StringBuilder();
        bool takeNext = true;
        foreach (char c in phrase)
        {
            if (char.IsLetter(c) && takeNext)
            {
                acronymBuilder.Append(char.ToUpperInvariant(c));
                takeNext = false;
            }
            else if (!char.IsLetter(c) && c != '\'')
            {
                takeNext = true;
            }
        }
        return acronymBuilder.ToString();   
    }
}