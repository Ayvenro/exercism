using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var result = text.Select(c =>
        {
            if (!char.IsLetter(c)) return c;
            var offset = char.IsUpper(c) ? 'A' : 'a';
            return (char)(offset + (c - offset + shiftKey) % 26);
        });
        return string.Concat(result);
    }
}