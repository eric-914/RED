using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models;

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
