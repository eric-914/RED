using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Service;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// Handles the RenderEngine.RenderLowResPreview process
    /// </summary>
    public class RenderLowResPreviewProcess : IAsyncAction
    {
        private readonly IConfiguration _configuration;
        private readonly IRenderEngine _re;

        public RenderLowResPreviewProcess(IConfiguration configuration, IRenderEngine re)
        {
            _configuration = configuration;
            _re = re;
        }

        public async Task Invoke()
        {
            await _re.RenderLowResPreviewAsync(_configuration.Model.RenderLowResPreview);
        }
    }
}
