using System;

namespace RenderEngineDesktop.Commands
{
    public class ActionCommand : BaseCommand
    {
        private readonly Action _action;

        public override void Execute() => _action();

        public ActionCommand(Action action)
        {
            _action = action;
        }
    }
}
