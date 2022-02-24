using RenderEngineDesktop.Models.Logging;
using RenderEngineDesktop.Service;
using System;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// Handles the RenderEngine.ListEnumeratedFonts process
    /// </summary>
    public class ListEnumeratedFontsProcess : IAsyncFunction<string, string>
    {
        private readonly ILogger _logger;
        private readonly IRenderEngine _re;

        /// <summary>
        /// Callback on complete
        /// </summary>
        public Action<string> OnComplete { get; set; } = _ => { };

        public ListEnumeratedFontsProcess(ILogger logger, IRenderEngine re)
        {
            _logger = logger;
            _re = re;
        }

        public async Task<string> Invoke()
        {
            return await _re.ListEnumeratedFontsAsync();
        }

        public void InvokeComplete(string result)
        {
            if (string.IsNullOrEmpty(result))
            {
                _logger.LogError("No font data returned");
                return;
            }

            OnComplete(result);
        }
    }
}
