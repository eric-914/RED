using RenderEngineDesktop.Service.Parameters.Groupings;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Process;

public class RenderOutputFilesWithWaterMarkModel : ISource, ITemplate, IOutputFiles, IWatermark
{
    public SourceModel Source { get; } = new();

    public TemplateModel Template { get; } = new();

    public PathsModel OutputFiles { get; } = new();

    public WaterMarkModel WaterMark { get; } = new();
}