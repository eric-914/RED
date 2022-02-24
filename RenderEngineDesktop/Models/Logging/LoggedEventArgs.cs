using System;

namespace RenderEngineDesktop.Models.Logging;

public delegate void LoggedEventHandler(object sender, LoggedEventArgs e);

public class LoggedEventArgs : EventArgs, ILogEvent
{
    private readonly LogEvent _event;

    public LoggedEventArgs(LogEvent @event)
    {
        _event = @event;
    }

    public LogType LogType => _event.LogType;
    public string Message => _event.Message;
    public Exception? Exception => _event.Exception;
}