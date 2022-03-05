using RenderEngineDesktop.Models.Assets;
using RenderEngineDesktop.Models.Process;
using RenderEngineDesktop.Service.Parameters.Models;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Models.Configuration
{
    public class ConfigurationModel
    {
        public string Uri { get; set; } = "net.tcp://localhost:1411/";
        public int ActiveTab { get; set; } = 0;
        public PathModel ApplicationFolder { get; } = new(ApplicationInformation.ApplicationFolder());

        public AssetPathModel AssetPath { get; } = new();

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
