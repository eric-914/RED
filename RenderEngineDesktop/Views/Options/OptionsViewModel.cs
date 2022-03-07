using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Application;
using System.Windows.Input;

namespace RenderEngineDesktop.Views.Options
{
    public class OptionsViewModel
    {
        public ApplicationModel Settings { get; } 

        public ICommand TestCommand { get; }

        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public OptionsViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public OptionsViewModel(ICommands commands, IApplication application)
        {
            Settings = application.Model;
            TestCommand = commands.Test;
        }
    }
}
