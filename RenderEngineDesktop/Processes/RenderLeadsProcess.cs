using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Service;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// Handles the RenderEngine.RenderLeads process
    /// </summary>
    public class RenderLeadsProcess : IAsyncAction
    {
        private readonly IConfiguration _configuration;
        private readonly IRenderEngine _re;

        public RenderLeadsProcess(IConfiguration configuration, IRenderEngine re)
        {
            _configuration = configuration;
            _re = re;
        }

        public async Task Invoke()
        {
            await _re.RenderLeadsAsync(_configuration.Model.RenderLeads);
        }
    }
}
