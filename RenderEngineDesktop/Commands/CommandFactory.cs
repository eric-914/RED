using RenderEngineDesktop.Commands.Process.Actions;
using RenderEngineDesktop.Commands.Process.Functions;
using RenderEngineDesktop.IoC;
using System;
using System.Windows.Input;
using System.Windows.Media;
using RenderEngineDesktop.Commands.Logging;
using RenderEngineDesktop.Commands.Menu;
using RenderEngineDesktop.Commands.SavedState;

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
        ICommand RenderOutputFilesWithWatermarkCommand();
        ICommand RenderPreviewCommand(Action<ImageSource> onComplete);
        ICommand RenderPreviewHtml5Command(Action<string> onComplete);
        ICommand RenderWatermarkedPreviewCommand(Action<ImageSource> action);
        ICommand RenderZoomedPreviewFragmentCommand(Action<ImageSource> action);
        ICommand ClearAllCommand();

        //Menu Commands
        ICommand FileExit();
        ICommand ConfigurationNew();
        ICommand ConfigurationOpen();
        ICommand ConfigurationSave();
        ICommand ConfigurationSaveAs();
        ICommand MacrosRun();
        ICommand MacrosRecord();
        ICommand MacrosOpen();
        ICommand MacrosSave();
        ICommand MacrosSaveAs();
        ICommand ConfigurationLoadState();
        ICommand MacroLoadState();
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

        public ICommand RenderOutputFilesWithWatermarkCommand() 
            => _factory.Get<RenderOutputFilesWithWatermarkCommand>();

        public ICommand ListEnumeratedFontsCommand(Action<string> onComplete) 
            => _factory.Get<ListEnumeratedFontsCommand, string>(onComplete);

        public ICommand RenderPreviewCommand(Action<ImageSource> onComplete) 
            => _factory.Get<RenderPreviewCommand, ImageSource>(onComplete);

        public ICommand RenderPreviewHtml5Command(Action<string> onComplete) 
            => _factory.Get<RenderPreviewHtml5Command, string>(onComplete);

        public ICommand RenderWatermarkedPreviewCommand(Action<ImageSource> onComplete) 
            => _factory.Get<RenderWatermarkedPreviewCommand, ImageSource>(onComplete);

        public ICommand RenderZoomedPreviewFragmentCommand(Action<ImageSource> onComplete) 
            => _factory.Get<RenderZoomedPreviewFragmentCommand, ImageSource>(onComplete);

        public ICommand ClearAllCommand()
            => _factory.Get<ClearAllCommand>();

        public ICommand FileExit()
            => _factory.Get<FileExitCommand>();

        public ICommand ConfigurationNew()
            => _factory.Get<ConfigurationNewCommand>();

        public ICommand ConfigurationOpen()
            => _factory.Get<ConfigurationOpenCommand>();

        public ICommand ConfigurationSave()
            => _factory.Get<ConfigurationSaveCommand>();

        public ICommand ConfigurationSaveAs()
            => _factory.Get<ConfigurationSaveAsCommand>();

        public ICommand ConfigurationLoadState()
            => _factory.Get<ConfigurationLoadStateCommand>();

        public ICommand MacrosRun()
            => _factory.Get<MacrosRunCommand>();

        public ICommand MacrosRecord()
            => _factory.Get<MacrosRecordCommand>();

        public ICommand MacrosOpen()
            => _factory.Get<MacrosOpenCommand>();

        public ICommand MacrosSave()
            => _factory.Get<MacrosSaveCommand>();
        
        public ICommand MacrosSaveAs()
            => _factory.Get<MacrosSaveAsCommand>();

        public ICommand MacroLoadState()
            => _factory.Get<MacroLoadStateCommand>();
    }
}
