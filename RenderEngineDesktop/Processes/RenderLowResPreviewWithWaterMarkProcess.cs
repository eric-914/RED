using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Service;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// Handles the RenderEngine.RenderLowResPreviewWithWaterMark process
    /// </summary>
    public class RenderLowResPreviewWithWaterMarkProcess : IAsyncAction
    {
        private readonly IConfiguration _configuration;
        private readonly IRenderEngine _re;

        public RenderLowResPreviewWithWaterMarkProcess(IConfiguration configuration, IRenderEngine re)
        {
            _configuration = configuration;
            _re = re;
        }

        public async Task Invoke()
        {
            await _re.RenderLowResPreviewWithWaterMarkAsync(_configuration.Model.RenderLowResPreviewWithWaterMark);
        }
    }
}
