using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Logging;
using RenderEngineDesktop.Service.Parameters.Models;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Input;

namespace RenderEngineDesktop.Views.Logging
{
    public class LogViewModel : NotifyModel
    {
        private readonly ILogDocumentModel _model = new NullLogDocumentModel();

        #region Properties

        public ICommand ClearAllCommand { get; } = default!;

        public FlowDocument Document
        {
            get => _model.Document;
            set => Set(_model.Document == value, () => _model.Document = value);
        }

        public bool ShowInformation
        {
            get => _model.Show.Information;
            set => Set(_model.Show.Information == value, () => _model.Show.Information = value);
        }

        public bool ShowErrors
        {
            get => _model.Show.Errors;
            set => Set(_model.Show.Errors == value, () => _model.Show.Errors = value);
        }

        public bool ShowExceptions
        {
            get => _model.Show.Exceptions;
            set => Set(_model.Show.Exceptions == value, () => _model.Show.Exceptions = value);
        }

        #endregion

        public LogViewModel() { }

        [Ninject.Inject]
        public LogViewModel(ILogger logger, ICommands commands, ILogDocumentModel model)
        {
            _model = model;

            logger.Events.CollectionChanged += LoggedEventsCollectionChanged;

            logger.LogInformation("Logging started.");

            ClearAllCommand = commands.ClearAllCommand();
        }

        private void LoggedEventsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    _model.AddRange(e.NewItems!.Cast<ILogEvent>());
                    break;

                case NotifyCollectionChangedAction.Reset:
                    _model.Reset();
                    break;
            }

            OnPropertyChanged(nameof(Document));
        }
    }
}
