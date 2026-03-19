using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var sb = new StringBuilder();
        foreach (var c in text)
        {
            if (char.IsLetter(c))
            {
                var offset = char.IsUpper(c) ? 'A' : 'a';
                var letter = (char)((((c + shiftKey) - offset) % 26) +  offset);
                sb.Append(letter);
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}