using System;

namespace RenderEngineDesktop.Models.Logging;

public delegate void LoggedErrorEventHandler(object sender, LoggedErrorEventArgs e);

public class LoggedErrorEventArgs : EventArgs
{
    public string Message { get; }

    public LoggedErrorEventArgs(string message)
    {
        Message = message;
    }
}