using System;
using System.Windows.Input;

namespace RenderEngineDesktop.Commands.SavedState
{
    /// <summary>
    /// Use for menu items that can retrieve a saved state
    /// </summary>
    public abstract class SavedStateCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private string _path = string.Empty;
        public string Path
        {
            get => _path;
            set
            {
                if (_path == value) return;

                _path = value;
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool CanExecute(object? parameter) => !string.IsNullOrEmpty(Path);

        public abstract void Execute(object? parameter);
    }
}
