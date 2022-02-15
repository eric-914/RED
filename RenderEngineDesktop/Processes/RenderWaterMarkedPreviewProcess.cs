using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Service;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// Handles the RenderEngine.RenderWaterMarkedPreview process
    /// </summary>
    public class RenderWaterMarkedPreviewProcess : IAsyncFunction<byte[]?>
    {
        private readonly IConfiguration _configuration;
        private readonly IRenderEngine _re;
        private readonly IBitmapTools _tools;

        /// <summary>
        /// Callback on complete
        /// </summary>
        public Action<ImageSource> OnComplete { get; set; } = _ => { };

        public RenderWaterMarkedPreviewProcess(IConfiguration configuration, IRenderEngine re, IBitmapTools tools)
        {
            _configuration = configuration;
            _re = re;
            _tools = tools;
        }

        public async Task<byte[]?> Invoke()
        {
            try
            {
                return await _re.RenderWaterMarkedPreviewAsync(_configuration.Model.RenderWaterMarkedPreview);
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected connection failure");
                throw;
            }
        }

        public void InvokeComplete(byte[]? bmp)
        {
            if (bmp == null || bmp.Length == 0)
            {
                MessageBox.Show("No image data returned");
                return;
            }

            ImageSource image = _tools.ToBitmapImage(bmp);

            OnComplete(image);
        }
    }
}
