using System.Text;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input)) return "";
        int count = 0;
        char currentChar = input[0];
        var sb = new StringBuilder();
        foreach (var c in input)
        {
            if (c == currentChar)
            {
                count++;
            }
            else
            {
                if (count > 1) sb.Append(count);
                sb.Append(currentChar);
                currentChar = c;
                count = 1;
            }
        }
        if (count > 1) sb.Append(count);
        sb.Append(currentChar);

        return sb.ToString();
    }

    public static string Decode(string input)
    {
        if (string.IsNullOrEmpty(input)) return "";
        var sb = new StringBuilder();
        var countStr = "";
        foreach (var c in input)
        {
            if (char.IsDigit(c))
            {
                countStr += c;
            }
            else
            {
                int count = string.IsNullOrEmpty(countStr) ? 1 : int.Parse(countStr);
                sb.Append(c, count);
                countStr = "";
            }
        }
        return sb.ToString();
    }
}