using System;
using System.Windows.Input;

namespace RenderEngineDesktop.Commands
{
    public abstract class BaseCommand : ICommand
    {
        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => Execute();

        public abstract void Execute();

        #region Unused

#pragma warning disable CS0067
        public event EventHandler? CanExecuteChanged;
#pragma warning restore CS0067

        #endregion
    }
}
