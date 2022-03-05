using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Models.Process;

namespace RenderEngineDesktop.Views.RenderLowResPreview
{
    public class RenderLowResPreviewViewModel : BaseServiceViewModel<RenderLowResPreviewModel>
    {
        public RenderLowResPreviewViewModel() { }

        [Ninject.Inject]
        public RenderLowResPreviewViewModel(ICommands commands, IConfiguration configuration)
        : base(configuration.Model.RenderLowResPreview)
        {
            SetInvoke(commands.RenderLowResPreviewCommand());
        }
    }
}
