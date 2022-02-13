using RenderEngineDesktop.Models.Common;
using System.IO;

namespace RenderEngineDesktop.Models.Assets
{
    /// <summary>
    /// Used to define the root path to the client assets
    /// \\[Server.Environment]\[Folders.AssetRoot]\[Folders.Toolbox]\[Folders.Environment]
    /// </summary>
    public class AssetPathModel : NotifyModel
    {
        public AssetServerModel Server { get; } = new();

        public AssetFoldersModel Folders { get; } = new();

        public PathModel Root { get; } = new();

        public AssetPathModel()
        {
            Server.PropertyChanged += (_, _) => UpdateRoot();
            Folders.PropertyChanged += (_, _) => UpdateRoot();
        }

        private void UpdateRoot()
        {
            Root.Path = Path.Join($@"\\{Server.Environment}", Folders.AssetRoot, Folders.Toolbox, Folders.Environment);
            OnPropertyChanged(nameof(Root));
        }
    }
}
