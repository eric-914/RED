using System.Windows.Input;
using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models;
using RenderEngineDesktop.Service;

namespace RenderEngineDesktop.Views.RenderOutputFiles
{
    public class RenderOutputFilesViewModel
    {
        private readonly IRenderEngine _re;

        public RenderOutputFilesModel Model { get; }
        public ICommand InvokeCommand { get; }

        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public RenderOutputFilesViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public RenderOutputFilesViewModel(ICommands commands, IRenderEngine re, IConfiguration configuration)
        {
            _re = re;

            Model = configuration.Model.RenderOutputFiles;
            InvokeCommand = commands.Action(Invoke);
        }

        private async void Invoke()
        {
            await _re.RenderOutputFilesAsync(Model);
        }
    }
}
