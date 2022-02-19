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

        ICommand ListEnumeratedFontsCommand(Action<string> onComplete);
        ICommand PrepZipDirectoryForParseCommand();
        ICommand RenderLeadsCommand();
        ICommand RenderLowResPreviewCommand();
        ICommand RenderOutputFilesCommand();
        ICommand RenderOutputFilesWithWaterMark();
        ICommand RenderPreviewCommand(Action<ImageSource> onComplete);
        ICommand RenderPreviewHtml5Command(Action<string> onComplete);
        ICommand RenderWaterMarkedPreviewCommand(Action<ImageSource> action);
        ICommand RenderZoomedPreviewFragmentCommand(Action<ImageSource> action);
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

        public ICommand ListEnumeratedFontsCommand(Action<string> onComplete)
        {
            return new ListEnumeratedFontsCommand(
                _factory.Get<ListEnumeratedFontsProcess>(),
                onComplete);

            //var process = _factory.Get<ListEnumeratedFontsProcess>();
            //process.OnComplete = onComplete;

            //return new AsyncFunctionCommand<string>(process);
        }

        public ICommand PrepZipDirectoryForParseCommand()
        {
            var process = _factory.Get<PrepZipDirectoryForParseProcess>();

            return new AsyncActionCommand(process);
        }

        public ICommand RenderLeadsCommand()
        {
            var process = _factory.Get<RenderLeadsProcess>();

            return new AsyncActionCommand(process);
        }

        public ICommand RenderLowResPreviewCommand()
        {
            var process = _factory.Get<RenderLowResPreviewProcess>();

            return new AsyncActionCommand(process);
        }

        public ICommand RenderOutputFilesCommand()
        {
            var process = _factory.Get<RenderOutputFilesProcess>();

            return new AsyncActionCommand(process);
        }

        public ICommand RenderOutputFilesWithWaterMark()
        {
            var process = _factory.Get<RenderOutputFilesWithWaterMarkProcess>();

            return new AsyncActionCommand(process);
        }

        public ICommand RenderPreviewCommand(Action<ImageSource> onComplete)
        {
            var process = _factory.Get<RenderPreviewProcess>();
            process.OnComplete = onComplete;

            return new AsyncFunctionCommand<byte[]?>(process);
        }

        public ICommand RenderPreviewHtml5Command(Action<string> onComplete)
        {
            var process = _factory.Get<RenderPreviewHtml5Process>();
            process.OnComplete = onComplete;

            return new AsyncFunctionCommand<string>(process);
        }

        public ICommand RenderWaterMarkedPreviewCommand(Action<ImageSource> onComplete)
        {
            var process = _factory.Get<RenderWaterMarkedPreviewProcess>();
            process.OnComplete = onComplete;

            return new AsyncFunctionCommand<byte[]?>(process);
        }

        public ICommand RenderZoomedPreviewFragmentCommand(Action<ImageSource> onComplete)
        {
            var process = _factory.Get<RenderZoomedPreviewFragmentProcess>();
            process.OnComplete = onComplete;

            return new AsyncFunctionCommand<byte[]?>(process);
        }
    }
}
