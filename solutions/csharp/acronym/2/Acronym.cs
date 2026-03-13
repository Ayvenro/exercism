using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    => String.Concat(Regex.Split(phrase, "[^A-Za-z']+").Select(x => char.ToUpper(x[0])));
}