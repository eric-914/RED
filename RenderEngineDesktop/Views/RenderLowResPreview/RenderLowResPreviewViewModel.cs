using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Process;

namespace RenderEngineDesktop.Views.RenderLowResPreview
{
    public class RenderLowResPreviewViewModel : BaseServiceViewModel<RenderLowResPreviewModel>
    {
        public RenderLowResPreviewViewModel() { }

        [Ninject.Inject]
        public RenderLowResPreviewViewModel(ICommands commands)
            : base(x => x.RenderLowResPreview)
        {
            SetInvoke(commands.RenderLowResPreviewCommand());
        }
    }
}
