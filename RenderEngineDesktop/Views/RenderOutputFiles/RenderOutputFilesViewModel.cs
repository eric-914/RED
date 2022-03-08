using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Process;

namespace RenderEngineDesktop.Views.RenderOutputFiles
{
    public class RenderOutputFilesViewModel : BaseServiceViewModel<RenderOutputFilesModel>
    {
        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public RenderOutputFilesViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public RenderOutputFilesViewModel(ICommands commands)
            : base(x => x.RenderOutputFiles)
        {
            SetInvoke(commands.RenderOutputFilesCommand());
        }
    }
}
