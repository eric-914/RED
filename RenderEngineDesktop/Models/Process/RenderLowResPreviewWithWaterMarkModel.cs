using RenderEngineDesktop.Service.Parameters.Groupings;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Process;

public class RenderLowResPreviewWithWaterMarkModel : ISource, ITemplate, IOutputFile, IWatermark
{
    public SourceModel Source { get; } = new();

    public TemplateModel Template { get; } = new();

    public PathModel OutputFile { get; set; } = new();

    public WaterMarkModel WaterMark { get; } = new();
}