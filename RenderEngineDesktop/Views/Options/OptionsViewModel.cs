using System.Windows.Input;
using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Views.Options
{
    public class OptionsViewModel
    {
        private readonly ISystemInformation _system;
        public ConfigurationModel Model { get; } = new();

        public ICommand BrowseCommand { get; }
        public ICommand TestCommand { get; }

        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public OptionsViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public OptionsViewModel(ICommands commands, IConfiguration configuration, ISystemInformation system)
        {
            _system = system;

            Model = configuration.Model;
            TestCommand = commands.Test;
            BrowseCommand = commands.Action(BrowseConfigurationFile);
        }

        private void BrowseConfigurationFile()
        {
            var path = _system.ApplicationLocalFolder();

            _system.OpenExplorer(path);
        }
    }
}
