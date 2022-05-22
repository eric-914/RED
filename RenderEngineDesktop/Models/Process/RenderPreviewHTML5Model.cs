using RenderEngineDesktop.Service.Parameters.Groupings;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Process;

public class RenderPreviewHtml5Model : ISource, ITemplate
{
    public SourceModel Source { get; } = new();

    public TemplateModel Template { get; } = new();
}
