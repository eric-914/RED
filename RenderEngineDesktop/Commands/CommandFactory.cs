using RenderEngineDesktop.Commands.Process.Actions;
using RenderEngineDesktop.Commands.Process.Functions;
using RenderEngineDesktop.IoC;
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
        ICommand RenderOutputFilesWithWaterMarkCommand();
        ICommand RenderPreviewCommand(Action<ImageSource> onComplete);
        ICommand RenderPreviewHtml5Command(Action<string> onComplete);
        ICommand RenderWaterMarkedPreviewCommand(Action<ImageSource> action);
        ICommand RenderZoomedPreviewFragmentCommand(Action<ImageSource> action);
    }

    /// <summary>
    /// Special repository for commands
    /// </summary>
    internal class CommandsFactory : ICommands
    {
        private readonly IFactory _factory;

        public CommandsFactory(IFactory factory)
        {
            _factory = factory;
        }

        /// <summary>
        /// The most generic type of command: execute the given action.
        /// </summary>
        public ICommand Action(Action action) => new ActionCommand(action);

        /// <summary>
        /// For testing
        /// </summary>
        public ICommand Test => _factory.Get<TestCommand>();

        public ICommand PrepZipDirectoryForParseCommand() 
            => _factory.Get<PrepZipDirectoryForParseCommand>();

        public ICommand RenderLeadsCommand() 
            => _factory.Get<RenderLeadsCommand>();

        public ICommand RenderLowResPreviewCommand() 
            => _factory.Get<RenderLowResPreviewCommand>();

        public ICommand RenderOutputFilesCommand() 
            => _factory.Get<RenderOutputFilesCommand>();

        public ICommand RenderOutputFilesWithWaterMarkCommand() 
            => _factory.Get<RenderOutputFilesWithWaterMarkCommand>();

        public ICommand ListEnumeratedFontsCommand(Action<string> onComplete) 
            => _factory.Get<ListEnumeratedFontsCommand, string>(onComplete);

        public ICommand RenderPreviewCommand(Action<ImageSource> onComplete) 
            => _factory.Get<RenderPreviewCommand, ImageSource>(onComplete);

        public ICommand RenderPreviewHtml5Command(Action<string> onComplete) 
            => _factory.Get<RenderPreviewHtml5Command, string>(onComplete);

        public ICommand RenderWaterMarkedPreviewCommand(Action<ImageSource> onComplete) 
            => _factory.Get<RenderWaterMarkedPreviewCommand, ImageSource>(onComplete);

        public ICommand RenderZoomedPreviewFragmentCommand(Action<ImageSource> onComplete) 
            => _factory.Get<RenderZoomedPreviewFragmentCommand, ImageSource>(onComplete);
    }
}
