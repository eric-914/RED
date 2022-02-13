using RenderEngineDesktop.Main;
using RenderEngineDesktop.Models;
using RenderEngineDesktop.Models.Assets;
using RenderEngineDesktop.Models.Common;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Configuration
{
    public class ConfigurationModel
    {
        public string Uri { get; set; } = "net.tcp://localhost:1411/";
        public ViewTabs ActiveTab { get; set; } = default;
        public PathModel ApplicationFolder { get; } = new(ApplicationInformation.ApplicationFolder());

        public AssetPathModel AssetPath { get; } = new();

        public RenderPreviewModel RenderPreview { get; } = new();
        public RenderOutputFilesModel RenderOutputFiles { get; } = new();
        public PrepZipDirectoryForParseModel PrepZipDirectoryForParse { get; } = new();
        public RenderLeadsModel RenderLeads { get; } = new();
        public RenderLowResPreviewModel RenderLowResPreview { get; } = new();
        public RenderOutputFilesWithWaterMarkModel RenderOutputFilesWithWaterMark { get; } = new();
        public RenderPreviewHtml5Model RenderPreviewHtml5 { get; } = new();
        public RenderWaterMarkedPreviewModel RenderWaterMarkedPreview { get; } = new();
        public RenderZoomedPreviewFragmentModel RenderZoomedPreview { get; } = new();
    }
}
