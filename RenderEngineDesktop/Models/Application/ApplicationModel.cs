using RenderEngineDesktop.Models.Environment;
using RenderEngineDesktop.Views.Logging;

namespace RenderEngineDesktop.Models.Application
{
    public class ApplicationModel
    {
        public string Uri { get; set; } = "net.tcp://localhost:1411/";
        public int ActiveTab { get; set; } = 0;

        public ApiVersions ApiVersion { get; set; } = ApiVersions.V1;

        public ApplicationPathModel Paths { get; } = new();

        public ApplicationWindowModel Window { get; } = new();

        public LogShowState LogShowState { get; }

        public ApplicationModel(LogShowState show)
        {
            LogShowState = show;
        }

        public void SetEnvironment(EnvironmentModel environment)
        {
            Uri = environment.Uri.AbsoluteUri;
            Paths.Asset.Server.Environment = environment.AssetServer;
            Paths.Asset.Folders.Environment = environment.AssetFolder;
        }
    }
}
