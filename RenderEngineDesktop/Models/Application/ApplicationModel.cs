using RenderEngineDesktop.Models.Assets;
using RenderEngineDesktop.Service.Parameters.Models;
using RenderEngineDesktop.Support;
using RenderEngineDesktop.Views.Logging;

namespace RenderEngineDesktop.Models.Application
{
    public class ApplicationModel
    {
        public string Uri { get; set; } = "net.tcp://localhost:1411/";
        public int ActiveTab { get; set; } = 0;
        public PathModel ApplicationFolder { get; } = new(ApplicationInformation.ApplicationFolder());

        public AssetPathModel AssetPath { get; } = new();

        public ApplicationPathModel CurrentPath { get; } = new();
        public ApplicationWindowModel Window { get; } = new();

        public LogShowState LogShowState { get; }

        public ApplicationModel(LogShowState show)
        {
            LogShowState = show;
        }
    }
}
