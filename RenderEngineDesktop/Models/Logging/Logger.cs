using System;

namespace RenderEngineDesktop.Models.Logging
{
    public interface ILogger
    {
        event LoggedInformationEventHandler? LoggedInformation;
        event LoggedErrorEventHandler? LoggedError;
        event LoggedExceptionEventHandler? LoggedException;

        void LogInformation(string message);
        void LogError(string message);
        void LogException(Exception ex, string? message = null);
    }

    // ReSharper disable InconsistentNaming
    public class Logger : ILogger
    {
        #region Information

        private readonly object _lockInformation = new();
        private event LoggedInformationEventHandler? _loggedInformation;
        public event LoggedInformationEventHandler? LoggedInformation
        {
            add
            {
                lock (_lockInformation)
                {
                    _loggedInformation += value;
                }
            }

            remove
            {
                lock (_lockInformation)
                {
                    _loggedInformation -= value;
                }
            }
        }

        public void LogInformation(string message)
        {
            _loggedInformation?.Invoke(this, new LoggedInformationEventArgs(message));
        }

        #endregion

        #region Error

        private readonly object _lockError = new();
        private event LoggedErrorEventHandler? _loggedError;
        public event LoggedErrorEventHandler? LoggedError
        {
            add
            {
                lock (_lockError)
                {
                    _loggedError += value;
                }
            }

            remove
            {
                lock (_lockError)
                {
                    _loggedError -= value;
                }
            }
        }

        public void LogError(string message)
        {
            _loggedError?.Invoke(this, new LoggedErrorEventArgs(message));
        }

        #endregion

        #region Exception

        private readonly object _lockException = new();
        private event LoggedExceptionEventHandler? _loggedException;
        public event LoggedExceptionEventHandler? LoggedException
        {
            add
            {
                lock (_lockException)
                {
                    _loggedException += value;
                }
            }
            remove
            {
                lock (_lockException)
                {
                    _loggedException -= value;
                }
            }
        }

        public void LogException(Exception ex, string? message = null)
        {
            _loggedException?.Invoke(this, new LoggedExceptionEventArgs(ex, message));
        }

        #endregion
    }
}
