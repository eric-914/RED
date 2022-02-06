using System;
using System.Collections.Generic;
using System.Linq;

namespace RenderEngineDesktop.Dialogs
{
    public class FileErrorMessageBoxModel
    {
        public Exception Exception { get; }
        public string Path { get; }
        public string Message { get; }
        public List<string> Additional { get; }

        public string ExceptionMessage => Exception.Message;
        public bool HasAdditional => Additional.Any();

        #region Design Mode Example 

        //--Used by XAML in design mode
        // ReSharper disable once UnusedMember.Global
        public FileErrorMessageBoxModel()
            : this(new Exception("Test exception information"), "Test path information", "Test message information") { }

        #endregion

        public FileErrorMessageBoxModel(Exception exception, string path, string message, params string[] additional)
        {
            Exception = exception;
            Path = path;
            Message = message;
            Additional = new List<string>(additional);
        }
    }
}
