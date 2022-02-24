using System;
using System.Collections.ObjectModel;

namespace RenderEngineDesktop.Models.Logging
{
    public interface ILogger
    {
        event LoggedEventHandler? LoggedEvent;

        ObservableCollection<LogEvent> Events { get; }

        void LogInformation(string message);
        void LogError(string message);
        void LogException(Exception ex, string? message = null);
    }

    // ReSharper disable InconsistentNaming
    public class Logger : ILogger
    {
        public ObservableCollection<LogEvent> Events { get; } = new();

        private readonly object _lock = new();
        private event LoggedEventHandler? _loggedEvent;
        public event LoggedEventHandler? LoggedEvent
        {
            add
            {
                lock (_lock)
                {
                    _loggedEvent += value;
                }
            }
            remove
            {
                lock (_lock)
                {
                    _loggedEvent -= value;
                }
            }
        }

        private void Log(LogEvent @event)
        {
            Events.Add(@event);
            _loggedEvent?.Invoke(this, new LoggedEventArgs(@event));
        }

        public void LogInformation(string message)
        {
            var @event = new LogEvent(LogType.Information, message);
            Log(@event);
        }

        public void LogError(string message)
        {
            var @event = new LogEvent(LogType.Error, message);
            Log(@event);
        }

        public void LogException(Exception ex, string? message = null)
        {
            var @event = new LogEvent(LogType.Exception, ex, message);
            Log(@event);
        }
    }
}
