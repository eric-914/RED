using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Common;
using System;
using System.Windows.Input;

namespace RenderEngineDesktop.Dialogs.ServiceError
{
    public class ServiceErrorMessageBoxViewModel : NotifyModel
    {
        public event EventHandler? Close;

        public ICommand OkCommand { get; }

        private ServiceErrorMessageBoxModel _model = new();
        public ServiceErrorMessageBoxModel Model
        {
            get => _model;
            set => Set(_model == value, () => _model = value);
        }

        #region XAML Design

        //--Used by the XAML Designer
#pragma warning disable CS8618
        public ServiceErrorMessageBoxViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public ServiceErrorMessageBoxViewModel(ICommands commands)
        {
            OkCommand = commands.Action(Ok);
        }

        private void Ok()
        {
            Close?.Invoke(this, EventArgs.Empty);
        }
    }
}
