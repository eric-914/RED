using RenderEngineDesktop.Service.Parameters.Groupings;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Process;

public class RenderLowResPreviewModel : ISource, ITemplate, IOutputFile
{
    public SourceModel Source { get; } = new();

    public TemplateModel Template { get; } = new();

    public PathModel OutputFile { get; set; } = new();
}