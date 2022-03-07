using RenderEngineDesktop.Service.Parameters.Models;
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

        public PathModel Root { get; private set; } = new();

        public AssetPathModel()
        {
            Server.PropertyChanged += (_, _) => UpdateRoot();
            Folders.PropertyChanged += (_, _) => UpdateRoot();
        }

        private void UpdateRoot()
        {
            Root = new PathModel(ToString(), true);
            OnPropertyChanged(nameof(Root));
        }

        public override string ToString() => Path.Join($@"\\{Server.Environment}", Folders.AssetRoot, Folders.Toolbox, Folders.Environment);
    }
}
