using RenderEngineDesktop.Service.Parameters.Groupings;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Process;

public class RenderWatermarkedPreviewModel : ISource, ITemplate, IMaximumInPixels, IOutlineColorComponent
{
    public SourceModel Source { get; } = new();

    public TemplateModel Template { get; } = new();

    public SizeModel<int> MaximumInPixels { get; } = new();

    public RgbModel OutlineColorComponent { get; } = new();
}