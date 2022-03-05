using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Service;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// Handles the RenderEngine.PrepZipDirectoryForParse process
    /// </summary>
    public class PrepZipDirectoryForParseProcess : IAsyncAction
    {
        private readonly IConfiguration _configuration;
        private readonly IRenderEngine _re;

        public PrepZipDirectoryForParseProcess(IConfiguration configuration, IRenderEngine re)
        {
            _configuration = configuration;
            _re = re;
        }

        public async Task Invoke()
        {
            await _re.PrepZipDirectoryForParseAsync(_configuration.Model.PrepZipDirectoryForParse);
        }
    }
}
