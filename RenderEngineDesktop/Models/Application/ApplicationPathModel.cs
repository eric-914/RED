using RenderEngineDesktop.Models.Assets;
using RenderEngineDesktop.Service.Parameters.Models;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Models.Application
{
    public class ApplicationPathModel
    {
        // ReSharper disable once InconsistentNaming
        private static readonly string _applicationFolder = ApplicationInformation.ApplicationFolder();

        public PathModel ApplicationFolder { get; } = new(_applicationFolder, true);

        public AssetPathModel Asset { get; } = new();

        public PathModel Configuration { get; } = new(_applicationFolder, "configuration.json");

        public PathModel Macros { get; } = new(_applicationFolder, "macro.json");
    }
}
