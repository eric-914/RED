using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Logging;
using RenderEngineDesktop.Service.Parameters.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Documents;
using System.Windows.Input;
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

        public ICommand ClearAllCommand { get; } = default!;

        private FlowDocument _document = new();
        public FlowDocument Document
        {
            get => _document;
            set => Set(_document==value, () => _document = value);
        }

        private bool _showInformation = true;
        public bool ShowInformation
        {
            get => _showInformation;
            set => Set(_showInformation == value, () => _showInformation = value);
        }

        private bool _showErrors = true;
        public bool ShowErrors
        {
            get => _showErrors;
            set => Set(_showErrors == value, () => _showErrors = value);
        }

        private bool _showExceptions = true;
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
        public LogViewModel(ILogger logger, ICommands commands) : this()
        {
            logger.Events.CollectionChanged += LoggedEventsCollectionChanged;

            logger.LogInformation("Logging started.");

            ClearAllCommand = commands.ClearAllCommand();
        }

        private void LoggedEventsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (var item in e.NewItems!)
                    {
                        var @event = (ILogEvent)(item);
                        _lookup[@event.LogType](@event);
                    }
                    break;

                case NotifyCollectionChangedAction.Reset:
                    Document = new FlowDocument();
                    break;
            }

            OnPropertyChanged(nameof(Document));
        }

        private void Add(Brush color, Inline inline)
        {
            var paragraph = new Paragraph(inline)
            {
                Foreground = color
            };

            Document.Blocks.Add(paragraph);
        }

        private void Information(ILogEvent e)
        {
            if (!_showInformation) return;

            Add(Colors.Information, new Run(e.Message));
        }

        private void Error(ILogEvent e)
        {
            if (!_showErrors) return;

            Add(Colors.Error, new Run(e.Message));
        }

        private void Exception(ILogEvent e)
        {
            if (!_showExceptions) return;

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
                span.Inlines.Add(new LineBreak());
                span.Inlines.Add(new Run(e.Exception.Message));

                Add(Colors.Exception, span);
            }
        }
    }
}
