using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Service;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace RenderEngineDesktop.Processes
{
    public class RenderPreviewHtml5Process : IAsyncFunction<string>
    {
        private readonly IConfiguration _configuration;
        private readonly IRenderEngine _re;

        /// <summary>
        /// Callback on complete
        /// </summary>
        public Action<string> OnComplete { get; set; } = _ => { };

        public RenderPreviewHtml5Process(IConfiguration configuration, IRenderEngine re)
        {
            _configuration = configuration;
            _re = re;
        }

        public async Task<string> Invoke()
        {
            try
            {
                return await _re.RenderPreviewHtml5Async(_configuration.Model.RenderPreviewHtml5);
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected connection failure");
                throw;
            }
        }

        public void InvokeComplete(string result)
        {
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("No HTML data returned");
                return;
            }

            OnComplete(result);
        }
    }
}
