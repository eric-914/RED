using System;
using System.Windows.Input;

namespace RenderEngineDesktop.Commands
{
    /// <summary>
    /// A base-class Command object where CanExecute() is always true.
    /// </summary>
    public abstract class CanExecuteCommand : ICommand
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
