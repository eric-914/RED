using RenderEngineDesktop.Models;
using System.Threading.Tasks;
using RenderEngineDesktop.Models.Process;

namespace RenderEngineDesktop.Service
{
    public interface IRenderEngine
    {
        Task<string> ListEnumeratedFontsAsync();
        Task<string> RenderPreviewHtml5Async(RenderPreviewHtml5Model m);

        Task<byte[]> RenderPreviewAsync(RenderPreviewModel m);
        Task<byte[]> RenderWaterMarkedPreviewAsync(RenderWaterMarkedPreviewModel m);
        Task<byte[]> RenderZoomedPreviewFragmentAsync(RenderZoomedPreviewFragmentModel m);

        Task RenderLeadsAsync(RenderLeadsModel m);
        Task RenderLowResPreviewAsync(RenderLowResPreviewModel m);
        Task RenderLowResPreviewWithWaterMarkAsync(RenderLowResPreviewWithWaterMarkModel m);
        Task RenderOutputFilesAsync(RenderOutputFilesModel m);
        Task RenderOutputFilesWithWaterMarkAsync(RenderOutputFilesWithWaterMarkModel m);
        Task PrepZipDirectoryForParseAsync(PrepZipDirectoryForParseModel m);
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
            return _service.RenderPreviewAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.MaximumInPixels.Width, m.MaximumInPixels.Height, m.OutlineColorComponent.Red, m.OutlineColorComponent.Green, m.OutlineColorComponent.Blue);
        }

        public Task RenderOutputFilesAsync(RenderOutputFilesModel m)
        {
            return _service.RenderOutputFilesAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.OutputFiles.Paths.ToArray());
        }

        public Task RenderLeadsAsync(RenderLeadsModel m)
        {
            return _service.RenderLeadsAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Leads.Ids.ToArray(), m.OutputFile.Path);
        }

        public Task RenderOutputFilesWithWaterMarkAsync(RenderOutputFilesWithWaterMarkModel m)
        {
            return _service.RenderOutputFilesWithWaterMarkAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.OutputFiles.Paths.ToArray(), m.WaterMark.Text);
        }

        public Task<string> RenderPreviewHtml5Async(RenderPreviewHtml5Model m)
        {
            return _service.RenderPreviewHTML5Async(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.Culture.Name);
        }

        public Task<byte[]> RenderWaterMarkedPreviewAsync(RenderWaterMarkedPreviewModel m)
        {
            return _service.RenderWaterMarkedPreviewAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.MaximumInPixels.Width, m.MaximumInPixels.Height, m.OutlineColorComponent.Red, m.OutlineColorComponent.Green, m.OutlineColorComponent.Blue);
        }

        public Task RenderLowResPreviewAsync(RenderLowResPreviewModel m)
        {
            return _service.RenderLowResPreviewAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.OutputFile.Path);
        }

        public Task RenderLowResPreviewWithWaterMarkAsync(RenderLowResPreviewWithWaterMarkModel m)
        {
            return _service.RenderLowResPreviewWithWaterMarkAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.OutputFile.Path, m.WaterMark.Text);
        }

        public Task<byte[]> RenderZoomedPreviewFragmentAsync(RenderZoomedPreviewFragmentModel m)
        {
            return _service.RenderZoomedPreviewFragmentAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.MaximumInPixels.Width, m.MaximumInPixels.Height, m.OutlineColorComponent.Red, m.OutlineColorComponent.Green, m.OutlineColorComponent.Blue, m.PercentTranslation.X, m.PercentTranslation.Y, m.Percentage.Width, m.Percentage.Height);
        }

        public Task PrepZipDirectoryForParseAsync(PrepZipDirectoryForParseModel m)
        {
            return _service.PrepZipDirectoryForParseAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.ZipFile.Path);
        }
    }
}
