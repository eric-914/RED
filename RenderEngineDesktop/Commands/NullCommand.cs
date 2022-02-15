using System;
using System.Windows.Input;

namespace RenderEngineDesktop.Commands
{
    /// <summary>
    /// A placeholder until a proper command exists
    /// </summary>
    internal class NullCommand : ICommand
    {
        public bool CanExecute(object? parameter) => false;

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS0067
        public event EventHandler? CanExecuteChanged;
#pragma warning restore CS0067
    }
}
