using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Process;

namespace RenderEngineDesktop.Views.RenderOutputFilesWithWatermark
{
    public class RenderOutputFilesWithWatermarkViewModel : BaseServiceViewModel<RenderOutputFilesWithWatermarkModel>
    {
        public RenderOutputFilesWithWatermarkViewModel() { }

        [Ninject.Inject]
        public RenderOutputFilesWithWatermarkViewModel(ICommands commands)
            : base(x => x.RenderOutputFilesWithWatermark)
        {
            SetInvoke(commands.RenderOutputFilesWithWatermarkCommand());
        }
    }
}
