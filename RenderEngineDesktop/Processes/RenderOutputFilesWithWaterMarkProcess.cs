using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Service;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// Handles the RenderEngine.RenderOutputFilesWithWatermark process
    /// </summary>
    public class RenderOutputFilesWithWatermarkProcess : IAsyncAction
    {
        private readonly IConfiguration _configuration;
        private readonly IRenderEngine _re;

        public RenderOutputFilesWithWatermarkProcess(IConfiguration configuration, IRenderEngine re)
        {
            _configuration = configuration;
            _re = re;
        }

        public async Task Invoke()
        {
            await _re.RenderOutputFilesWithWatermarkAsync(_configuration.Model.RenderOutputFilesWithWatermark);
        }
    }
}
