using System;
using System.Security.RightsManagement;
using RenderEngineDesktop.IoC;
using System.Windows.Input;

namespace RenderEngineDesktop.Commands
{
    public interface ICommands
    {
        ICommand Action(Action action);

        ICommand Test { get; }
    }

    internal class CommandsFactory : ICommands
    {
        private readonly IFactory _factory;

        public CommandsFactory(IFactory factory)
        {
            _factory = factory;
        }

        public ICommand Action(Action action) => new ActionCommand(action);

        public ICommand Test => _factory.Get<TestCommand>();
    }
}
