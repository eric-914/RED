using System;
using System.Diagnostics;
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
                Debug.WriteLine($"IsBusy={_isBusy}");
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool CanExecute(object? parameter) => !IsBusy;

        public abstract void Execute(object? parameter);
    }
}
