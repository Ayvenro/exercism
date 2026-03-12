using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string input, string delimiter)
    {
        int index = input.IndexOf(delimiter);
        return input.Substring(index + delimiter.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string input, string first, string last)
    {
        int firstIndex = input.IndexOf(first);
        int lastIndex = input.IndexOf(last);
        return input.Substring(firstIndex + first.Length, lastIndex - firstIndex - first.Length);
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string input) => input.SubstringAfter(": ");
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string input) => input.SubstringBetween("[", "]");
}