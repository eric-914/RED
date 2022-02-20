using RenderEngineDesktop.Service.Parameters.Groupings;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Process;

public class PrepZipDirectoryForParseModel : ISource, IZipFile
{
    public SourceModel Source { get; } = new();

    public PathModel ZipFile { get; } = new();
}