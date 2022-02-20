using System;

namespace RenderEngineDesktop.Commands
{
    /// <summary>
    /// A simple Command class to bind an action to a command.
    /// </summary>
    public class ActionCommand : CanExecuteCommand
    {
        private readonly Action _action;

        public override void Execute() => _action();

        public ActionCommand(Action action)
        {
            _action = action;
        }
    }
}
