using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Service.Parameters.Models
{
    /// <summary>
    /// Common definition for a SINGLE file path.
    /// </summary>
    public class PathModel : NotifyModel
    {
        private readonly bool _isReadOnly;

        public PathModel() { }

        public PathModel(string path, bool isReadOnly = false)
        {
            Path = path;
            _isReadOnly = isReadOnly;
        }

        public PathModel(string path, string file, bool isReadOnly = false) 
            : this(System.IO.Path.Combine(path, file), isReadOnly) { }

        private string _path = string.Empty;
        public string Path
        {
            get => _path;
            set
            {
                if (!_isReadOnly)
                {
                    Set(_path == value, () => _path = value);
                }
            }
        }

        public void Browse() => FileExplorer.Open(Path);
    }
}
