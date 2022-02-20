using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Assets
{
    public class AssetFoldersModel : NotifyModel
    {
        private string _assetRoot = string.Empty;
        public string AssetRoot
        {
            get => _assetRoot;
            set => Set(_assetRoot == value, () => _assetRoot = value);
        }

        private string _toolbox = string.Empty;
        public string Toolbox
        {
            get => _toolbox;
            set => Set(_toolbox == value, () => _toolbox = value);
        }

        private string _environment = string.Empty;
        public string Environment
        {
            get => _environment;
            set => Set(_environment == value, () => _environment = value);
        }
    }
}
