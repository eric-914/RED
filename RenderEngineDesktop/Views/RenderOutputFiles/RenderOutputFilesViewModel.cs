using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models;
using System.Windows.Input;

namespace RenderEngineDesktop.Views.RenderOutputFiles
{
    public class RenderOutputFilesViewModel
    {
        public RenderOutputFilesModel Model { get; }
        public ICommand InvokeCommand { get; }

        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public RenderOutputFilesViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public RenderOutputFilesViewModel(ICommands commands, IConfiguration configuration)
        {
            Model = configuration.Model.RenderOutputFiles;
            InvokeCommand = commands.RenderOutputFilesCommand();
        }
    }
}
