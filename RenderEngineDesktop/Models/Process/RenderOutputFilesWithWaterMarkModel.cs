using RenderEngineDesktop.Service.Parameters.Groupings;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Process;

public class RenderOutputFilesWithWatermarkModel : ISource, ITemplate, IOutputFiles, IWatermark
{
    public SourceModel Source { get; } = new();

    public TemplateModel Template { get; } = new();

    public PathsModel OutputFiles { get; } = new();

    public WatermarkModel Watermark { get; } = new();
}