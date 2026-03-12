public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        bool isQuestion = statement.EndsWith("?");
        bool isYell = statement.Any(char.IsLetter) && statement == statement.ToUpper();

        if (string.IsNullOrWhiteSpace(statement)) return "Fine. Be that way!";
        
        switch ((isQuestion, isYell))
        {
            case (true, true): return "Calm down, I know what I'm doing!";
            case (true, _): return "Sure.";
            case (_, true): return "Whoa, chill out!"; 
            default: return "Whatever.";
        }
    }
}