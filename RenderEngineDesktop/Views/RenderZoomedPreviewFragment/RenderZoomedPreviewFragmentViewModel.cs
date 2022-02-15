using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models;

namespace RenderEngineDesktop.Views.RenderZoomedPreviewFragment
{
    public class RenderZoomedPreviewFragmentViewModel : BaseServiceViewModel<RenderZoomedPreviewFragmentModel>
    {
        public RenderZoomedPreviewFragmentViewModel() { }

        [Ninject.Inject]
        public RenderZoomedPreviewFragmentViewModel(ICommands commands, IConfiguration configuration)
        : base(configuration.Model.RenderZoomedPreviewFragment)
        {
            SetInvoke(commands.RenderZoomedPreviewFragmentCommand(_ => { }));
        }
    }
}
