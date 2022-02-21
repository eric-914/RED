using RenderEngineDesktop.Service.Parameters.Groupings;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Process;

public class RenderLowResPreviewWithWatermarkModel : ISource, ITemplate, IOutputFile, IWatermark
{
    public SourceModel Source { get; } = new();

    public TemplateModel Template { get; } = new();

    public PathModel OutputFile { get; set; } = new();

    public WatermarkModel Watermark { get; } = new();
}