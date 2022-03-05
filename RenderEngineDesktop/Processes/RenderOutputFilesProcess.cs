using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Service;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    public class RenderOutputFilesProcess : IAsyncAction
    {
        private readonly IRenderEngine _re;
        private readonly IConfiguration _configuration;

        public RenderOutputFilesProcess(IRenderEngine re, IConfiguration configuration)
        {
            _re = re;
            _configuration = configuration;
        }
        
        public async Task Invoke()
        {
            await _re.RenderOutputFilesAsync(_configuration.Model.RenderOutputFiles);
        }
    }
}
