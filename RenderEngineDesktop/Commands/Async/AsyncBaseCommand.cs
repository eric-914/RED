using System;
using System.Windows.Input;

namespace RenderEngineDesktop.Commands.Async
{
    /// <summary>
    /// Handle busy state during async execution process
    /// </summary>
    public abstract class AsyncBaseCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if (_isBusy == value) return;

                _isBusy = value;
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool CanExecute(object? parameter) => !IsBusy;

        public void Execute(object? parameter)
        {
            IsBusy = true;

            Execute();

            IsBusy = false;
        }

        public abstract void Execute();
    }
}
