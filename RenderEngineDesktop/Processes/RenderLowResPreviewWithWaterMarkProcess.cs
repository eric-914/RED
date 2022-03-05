using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Service;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// Handles the RenderEngine.RenderLowResPreviewWithWatermark process
    /// </summary>
    public class RenderLowResPreviewWithWatermarkProcess : IAsyncAction
    {
        private readonly IConfiguration _configuration;
        private readonly IRenderEngine _re;

        public RenderLowResPreviewWithWatermarkProcess(IConfiguration configuration, IRenderEngine re)
        {
            _configuration = configuration;
            _re = re;
        }

        public async Task Invoke()
        {
            await _re.RenderLowResPreviewWithWatermarkAsync(_configuration.Model.RenderLowResPreviewWithWatermark);
        }
    }
}
