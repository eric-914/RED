using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Service.Parameters.Models
{
    /// <summary>
    /// Common definition for a SINGLE file path.
    /// </summary>
    public class PathModel
    {
        private readonly bool _isReadOnly;

        public PathModel() { }

        public PathModel(string path)
        {
            Path = path;
            _isReadOnly = true;
        }

        private string _path = string.Empty;
        public string Path
        {
            get => _path;
            set
            {
                if (!_isReadOnly)
                {
                    _path = value;
                }
            }
        }

        public void Browse() => FileExplorer.Open(Path);
    }
}
