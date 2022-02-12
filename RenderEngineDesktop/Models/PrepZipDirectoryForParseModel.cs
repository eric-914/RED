using RenderEngineDesktop.Models.Common;

namespace RenderEngineDesktop.Models
{
    public class PrepZipDirectoryForParseModel
    {
        public SourceModel Source { get; } = new();

        public PathModel ZipFile { get; } = new();
    }
}
