using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int colonIndex = logLine.IndexOf(":");
        return logLine.Substring(colonIndex + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int firstIndex = logLine.IndexOf("[");
        int lastIndex = logLine.LastIndexOf("]");
        return logLine.Substring(firstIndex + 1, lastIndex - 1).ToLower();
    }

    public static string Reformat(string logLine)
    {
         return ($"{Message(logLine)} ({LogLevel(logLine)})");
    }
}
