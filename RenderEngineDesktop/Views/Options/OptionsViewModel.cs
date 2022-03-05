using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Configuration;
using System.Windows.Input;

namespace RenderEngineDesktop.Views.Options
{
    public class OptionsViewModel
    {
        public ConfigurationModel Model { get; } = new();

        public ICommand TestCommand { get; }

        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public OptionsViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public OptionsViewModel(ICommands commands, IConfiguration configuration)
        {
            Model = configuration.Model;
            TestCommand = commands.Test;
        }
    }
}
