public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        bool isQuestion = statement.EndsWith("?");
        bool isYelling = statement.Any(char.IsLetter) && statement == statement.ToUpper();
        
        if (isQuestion && isYelling) return "Calm down, I know what I'm doing!";
        else if (string.IsNullOrWhiteSpace(statement)) return "Fine. Be that way!";
        else if (isQuestion) return "Sure.";
        else if (isYelling) return "Whoa, chill out!";
        else return "Whatever.";
    }
}