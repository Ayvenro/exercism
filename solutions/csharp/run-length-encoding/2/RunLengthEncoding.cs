using System.Text.RegularExpressions;

public static partial class RunLengthEncoding
{
    public static string Encode(string input) =>
        EncodeRegex().Replace(input, m 
            => m.Length.ToString() + m.Value[0]);

    public static string Decode(string input) =>
        DecodeRegex().Replace(input, m 
            => new string(m.Groups[2].Value[0], int.Parse(m.Groups[1].Value)));
    
    [GeneratedRegex(@"(\D)\1+")]
    private static partial Regex EncodeRegex();
    
    [GeneratedRegex(@"(\d+)(\D)")]
    private static partial Regex DecodeRegex();
}

