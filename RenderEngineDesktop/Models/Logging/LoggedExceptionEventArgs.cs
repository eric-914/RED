using System;

namespace RenderEngineDesktop.Models.Logging;

public delegate void LoggedExceptionEventHandler(object sender, LoggedExceptionEventArgs e);

public class LoggedExceptionEventArgs : EventArgs
{
    public string? Message { get; }
    public Exception Exception { get; }

    public LoggedExceptionEventArgs(Exception ex, string? message = null)
    {
        Exception = ex;
        Message = message;
    }
}