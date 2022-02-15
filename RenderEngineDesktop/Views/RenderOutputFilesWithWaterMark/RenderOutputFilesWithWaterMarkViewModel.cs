using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models;

namespace RenderEngineDesktop.Views.RenderOutputFilesWithWaterMark
{
    public class RenderOutputFilesWithWaterMarkViewModel : BaseServiceViewModel<RenderOutputFilesWithWaterMarkModel>
    {
        public RenderOutputFilesWithWaterMarkViewModel() { }

        [Ninject.Inject]
        public RenderOutputFilesWithWaterMarkViewModel(ICommands commands, IConfiguration configuration)
        : base(configuration.Model.RenderOutputFilesWithWaterMark)
        {
            SetInvoke(commands.RenderOutputFilesWithWaterMark());
        }
    }
}
