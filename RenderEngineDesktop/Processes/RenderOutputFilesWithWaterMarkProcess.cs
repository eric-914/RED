using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Service;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// Handles the RenderEngine.RenderOutputFilesWithWaterMark process
    /// </summary>
    public class RenderOutputFilesWithWaterMarkProcess : IAsyncAction
    {
        private readonly IConfiguration _configuration;
        private readonly IRenderEngine _re;

        public RenderOutputFilesWithWaterMarkProcess(IConfiguration configuration, IRenderEngine re)
        {
            _configuration = configuration;
            _re = re;
        }

        public async Task Invoke()
        {
            await _re.RenderOutputFilesWithWaterMarkAsync(_configuration.Model.RenderOutputFilesWithWaterMark);
        }
    }
}
