using RenderEngineDesktop.Models;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Service
{
    public interface IRenderEngine
    {
        Task<string> ListEnumeratedFontsAsync();
        Task<byte[]> RenderPreviewAsync(RenderPreviewModel m);
        public Task RenderOutputFilesAsync(RenderOutputFilesModel m);
    }

    public class RenderEngine : IRenderEngine
    {
        private readonly IRenderEngineService _service;

        public RenderEngine(IRenderEngineService service)
        {
            _service = service;
        }

        public Task<string> ListEnumeratedFontsAsync()
        {
            return _service.ListEnumeratedFontsAsync();
        }

        public Task<byte[]> RenderPreviewAsync(RenderPreviewModel m)
        {
            return _service.RenderPreviewAsync(m.ClientId, m.Instance, m.Environment, m.Key, m.TemplateInstanceId, m.MaximumWidthInPixels, m.MaximumHeightInPixels, m.OutlineColorRedComponent, m.OutlineColorGreenComponent, m.OutlineColorBlueComponent);
        }

        public Task RenderOutputFilesAsync(RenderOutputFilesModel m)
        {
            return _service.RenderOutputFilesAsync(m.ClientId, m.Instance, m.Environment, m.Key, m.TemplateInstanceId, m.OutputFilePaths.ToArray());
        }
    }
}
