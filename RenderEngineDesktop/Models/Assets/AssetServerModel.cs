using RenderEngineDesktop.Models.Common;

namespace RenderEngineDesktop.Models.Assets
{
    public class AssetServerModel : NotifyModel
    {
        private string _environment = string.Empty;
        public string Environment
        {
            get => _environment;
            set => Set(_environment == value, () => _environment = value);
        }
    }
}
