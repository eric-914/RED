using System;

namespace RenderEngineDesktop.Models.Logging;

public delegate void LoggedInformationEventHandler(object sender, LoggedInformationEventArgs e);

public class LoggedInformationEventArgs : EventArgs
{
    public string Message { get; }

    public LoggedInformationEventArgs(string message)
    {
        Message = message;
    }
}
