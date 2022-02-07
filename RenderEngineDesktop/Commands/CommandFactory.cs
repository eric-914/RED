using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Processes;
using System;
using System.Windows.Input;
using System.Windows.Media;

namespace RenderEngineDesktop.Commands
{
    public interface ICommands
    {
        ICommand Action(Action action);

        ICommand Test { get; }

        ICommand RenderPreviewCommand(Action<ImageSource> onComplete);
        ICommand RenderOutputFilesCommand();
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

        public ICommand RenderPreviewCommand(Action<ImageSource> onComplete)
        {
            var process = _factory.Get<RenderPreviewProcess>();
            process.OnComplete = onComplete;

            return new AsyncFunctionCommand<byte[]?>(process);
        }

        public ICommand RenderOutputFilesCommand()
        {
            var process = _factory.Get<RenderOutputFilesProcess>();

            return new AsyncActionCommand(process);
        }
    }
}
