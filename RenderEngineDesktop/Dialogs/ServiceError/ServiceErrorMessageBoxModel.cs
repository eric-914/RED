using System;

namespace RenderEngineDesktop.Dialogs.ServiceError
{
    public class ServiceErrorMessageBoxModel
    {
        public Exception Exception { get; }

        public string ExceptionType => Exception.GetType().Name;
        public string ExceptionMessage => Exception.Message;

        #region Design Mode Example 

        //--Used by XAML in design mode
        // ReSharper disable once UnusedMember.Global
        public ServiceErrorMessageBoxModel()
            : this(new Exception("Test exception information")) { }

        #endregion

        public ServiceErrorMessageBoxModel(Exception exception)
        {
            Exception = exception;
        }
    }
}
