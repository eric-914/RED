using System;

namespace RenderEngineDesktop.Models.Logging
{
    public interface ILogEvent
    {
        LogType LogType { get; }
        string Message { get; }
        Exception? Exception { get; }
    }

    public class LogEvent : ILogEvent
    {
        public LogType LogType { get; }

        public string Message { get; }

        public Exception? Exception { get; }

        public LogEvent(LogType type, string message)
        {
            LogType = type;
            Message = message;
        }

        public LogEvent(LogType type, Exception ex, string? message = null) : this(type, message ?? string.Empty)
        {
            Exception = ex;
        }
    }
}
