internal enum LogLevel
{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        var start = logLine.IndexOf('[') + 1;
        var end = logLine.IndexOf(']');
        var levelPart = logLine.Substring(start, end - start);
        return levelPart switch
        {
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown
        };
    }

    public static string OutputForShortLog(LogLevel logLevel, string message) => $"{(int)logLevel}:{message}";
}