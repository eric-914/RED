using System;
using System.Windows.Input;

namespace RenderEngineDesktop.Commands.Async
{
    /// <summary>
    /// Provides a busy state during an async execution process
    /// CanExecute is disabled when Busy
    /// </summary>
    /// <remarks>
    /// It seems the children have to turn Busy on/off within their async process.
    /// Otherwise, the UI doesn't update properly.
    /// </remarks>
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

        public abstract void Execute(object? parameter);
    }
}
