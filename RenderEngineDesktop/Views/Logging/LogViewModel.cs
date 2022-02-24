using RenderEngineDesktop.Models.Logging;
using RenderEngineDesktop.Service.Parameters.Models;
using System;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Media;

namespace RenderEngineDesktop.Views.Logging
{
    public class LogViewModel : NotifyModel
    {
        public static class Colors
        {
            public static readonly SolidColorBrush Information = new(Color.FromRgb(192, 192, 0));
            public static readonly SolidColorBrush Error = new(Color.FromRgb(255, 92, 64));
            public static readonly SolidColorBrush Exception = new(Color.FromRgb(224, 0, 0));
        }

        private readonly Dictionary<LogType, Action<ILogEvent>> _lookup;

        #region Properties

        private FlowDocument _document = new();
        public FlowDocument Document
        {
            get => _document;
            set => Set(_document==value, () => _document = value);
        }

        private bool _showInformation;
        public bool ShowInformation
        {
            get => _showInformation;
            set => Set(_showInformation == value, () => _showInformation = value);
        }

        private bool _showErrors;
        public bool ShowErrors
        {
            get => _showErrors;
            set => Set(_showErrors == value, () => _showErrors = value);
        }

        private bool _showExceptions;
        public bool ShowExceptions
        {
            get => _showExceptions;
            set => Set(_showExceptions == value, () => _showExceptions = value);
        }

        #endregion

        public LogViewModel()
        {
            _lookup = new Dictionary<LogType, Action<ILogEvent>>
            {
                {LogType.Information, Information},
                {LogType.Error, Error},
                {LogType.Exception, Exception},
            };
        }

        [Ninject.Inject]
        public LogViewModel(ILogger logger) : this()
        {
            logger.LoggedEvent += LoggedEventHandler;

            logger.LogInformation("Logging started.");
        }

        private void Add(Brush color, Inline inline)
        {
            var paragraph = new Paragraph(inline)
            {
                Foreground = color
            };

            Document.Blocks.Add(paragraph);
        }

        private void LoggedEventHandler(object sender, ILogEvent e)
        {
            _lookup[e.LogType](e);

            OnPropertyChanged(nameof(Document));
        }

        private void Information(ILogEvent e)
        {
            Add(Colors.Information, new Run(e.Message));
        }

        private void Error(ILogEvent e)
        {
            Add(Colors.Error, new Run(e.Message));
        }

        private void Exception(ILogEvent e)
        {
            if (e.Exception == null)
            {
                Add(Colors.Exception, new Run(e.Message));
            }
            else if (string.IsNullOrEmpty(e.Message))
            {
                Add(Colors.Exception, new Run(e.Exception.Message));
            }
            else
            {
                var span = new Span();
                span.Inlines.Add(new Run(e.Message));
                span.Inlines.Add(new Run(e.Exception.Message));

                Add(Colors.Exception, span);
            }
        }
    }
}
