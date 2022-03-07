using RenderEngineDesktop.Models.Process;

namespace RenderEngineDesktop.Models.Configuration
{
    /// <summary>
    /// Central repository for all tabs and its configuration models.
    /// </summary>
    public class ConfigurationModel
    {
        public PrepZipDirectoryForParseModel PrepZipDirectoryForParse { get; } = new();
        public RenderLeadsModel RenderLeads { get; } = new();
        public RenderLowResPreviewModel RenderLowResPreview { get; } = new();
        public RenderLowResPreviewWithWatermarkModel RenderLowResPreviewWithWatermark { get; } = new();
        public RenderOutputFilesModel RenderOutputFiles { get; } = new();
        public RenderOutputFilesWithWatermarkModel RenderOutputFilesWithWatermark { get; } = new();
        public RenderPreviewHtml5Model RenderPreviewHtml5 { get; } = new();
        public RenderPreviewModel RenderPreview { get; } = new();
        public RenderWatermarkedPreviewModel RenderWatermarkedPreview { get; } = new();
        public RenderZoomedPreviewFragmentModel RenderZoomedPreviewFragment { get; } = new();
    }
}
