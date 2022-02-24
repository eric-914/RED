using RenderEngineDesktop.Models.Logging;
using RenderEngineDesktop.Service.Parameters.Models;
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

        private FlowDocument _document = new();

        public FlowDocument Document
        {
            get => _document;
            set
            {
                if (value == _document) return;

                _document = value;
                OnPropertyChanged();
            }
        }

        #region XAML Design

        //--Used by XAML Designer
#pragma warning disable CS8618
        public LogViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public LogViewModel(ILogger logger)
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
            OnPropertyChanged("Document");
        }

        private void LoggedEventHandler(object sender, ILogEvent e)
        {
            switch (e.LogType)
            {
                case LogType.Information:
                    Information(e);
                    break;

                case LogType.Error:
                    Error(e);
                    break;

                case LogType.Exception:
                    Exception(e);
                    break;
            }
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
                span.Inlines.Add(new Run(e.Exception.Message));
                span.Inlines.Add(new Run(e.Message));

                Add(Colors.Exception, span);
            }
        }
    }
}
