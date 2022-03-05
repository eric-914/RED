using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Models.Logging;
using RenderEngineDesktop.Service;
using RenderEngineDesktop.Support;
using System;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// Handles the RenderEngine.RenderPreview process
    /// </summary>
    public class RenderPreviewProcess : IAsyncFunction<byte[]?, ImageSource>
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        private readonly IRenderEngine _re;
        private readonly IBitmapTools _tools;

        /// <summary>
        /// Callback on complete
        /// </summary>
        public Action<ImageSource> OnComplete { get; set; } = _ => { };

        public RenderPreviewProcess(ILogger logger, IConfiguration configuration, IRenderEngine re, IBitmapTools tools)
        {
            _logger = logger;
            _configuration = configuration;
            _re = re;
            _tools = tools;
        }

        /// <summary>
        /// Pass the model off to Render Engine
        /// </summary>
        /// <returns>byte[] image</returns>
        public async Task<byte[]?> Invoke()
        {
            try
            {
                return await _re.RenderPreviewAsync(_configuration.Model.RenderPreview);
            }
            catch (Exception)
            {
                _logger.LogError("Unexpected connection failure");
                throw;
            }
        }

        /// <summary>
        /// Convert the byte[] image into a usable image and pass back to the invoker.
        /// </summary>
        /// <param name="bmp">byte[] image</param>
        public void InvokeComplete(byte[]? bmp)
        {
            if (bmp == null || bmp.Length == 0)
            {
                _logger.LogError("No image data returned");
                return;
            }

            ImageSource image = _tools.ToBitmapImage(bmp);

            OnComplete(image);
        }
    }
}
