public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        bool isQuestion = statement.EndsWith("?");
        bool isYell = statement.Any(char.IsLetter) && statement == statement.ToUpper();
        
        if (isQuestion && isYell) return "Calm down, I know what I'm doing!";
        else if (string.IsNullOrWhiteSpace(statement)) return "Fine. Be that way!";
        else if (isQuestion) return "Sure.";
        else if (isYell) return "Whoa, chill out!";
        else return "Whatever.";
    }
}