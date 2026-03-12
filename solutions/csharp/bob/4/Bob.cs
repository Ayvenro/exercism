public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        bool isQuestion = statement.EndsWith("?");
        bool isYell = statement.Any(char.IsLetter) && statement == statement.ToUpper();

        if (string.IsNullOrWhiteSpace(statement)) return "Fine. Be that way!";
        
        return ((isQuestion, isYell)) switch
        {
            (true, true) => "Calm down, I know what I'm doing!",
            (true, _) => "Sure.",
            (_, true) => "Whoa, chill out!", 
            _ => "Whatever."
        };
    }
}