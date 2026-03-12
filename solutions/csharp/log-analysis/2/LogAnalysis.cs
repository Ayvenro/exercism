using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string input, string delimiter) => input[(input.IndexOf(delimiter) + delimiter.Length)..];

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string input, string first, string last) => input[(input.IndexOf(first) + first.Length)..input.IndexOf(last)];
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string input) => input.SubstringAfter(": ");
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string input) => input.SubstringBetween("[", "]");
}