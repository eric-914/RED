using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Models.Process;

namespace RenderEngineDesktop.Views.RenderOutputFilesWithWatermark
{
    public class RenderOutputFilesWithWatermarkViewModel : BaseServiceViewModel<RenderOutputFilesWithWatermarkModel>
    {
        public RenderOutputFilesWithWatermarkViewModel() { }

        [Ninject.Inject]
        public RenderOutputFilesWithWatermarkViewModel(ICommands commands, IConfiguration configuration)
        : base(configuration.Model.RenderOutputFilesWithWatermark)
        {
            SetInvoke(commands.RenderOutputFilesWithWatermarkCommand());
        }
    }
}
