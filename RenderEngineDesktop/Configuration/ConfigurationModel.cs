using RenderEngineDesktop.Main;
using RenderEngineDesktop.Models;

namespace RenderEngineDesktop.Configuration
{
    public class ConfigurationModel
    {
        public string Uri { get; set; } = "net.tcp://localhost:1411/";
        public ViewTabs ActiveTab { get; set; } = default;

        public RenderPreviewModel RenderPreview { get; } = new ();
        public RenderOutputFilesModel RenderOutputFiles { get; } = new();
    }
}
