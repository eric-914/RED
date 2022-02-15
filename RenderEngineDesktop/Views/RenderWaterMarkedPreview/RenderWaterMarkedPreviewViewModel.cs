using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models;

namespace RenderEngineDesktop.Views.RenderWaterMarkedPreview
{
    public class RenderWaterMarkedPreviewViewModel : BaseServiceViewModel<RenderWaterMarkedPreviewModel>
    {
        public RenderWaterMarkedPreviewViewModel() { }

        [Ninject.Inject]
        public RenderWaterMarkedPreviewViewModel(ICommands commands, IConfiguration configuration)
        : base(configuration.Model.RenderWaterMarkedPreview)
        {
            SetInvoke(commands.RenderWaterMarkedPreviewCommand(_ => { }));
        }
    }
}
