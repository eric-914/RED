using RenderEngineDesktop.Service.Parameters.Groupings;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Process;

public class RenderZoomedPreviewFragmentModel : ISource, ITemplate, IMaximumInPixels, IOutlineColorComponent,
    IPercentTranslation, IPercentage
{
    public SourceModel Source { get; } = new();

    public TemplateModel Template { get; } = new();

    public SizeModel<int> MaximumInPixels { get; } = new();

    public RgbModel OutlineColorComponent { get; } = new();

    public PointModel<float> PercentTranslation { get; } = new();

    public SizeModel<float> Percentage { get; } = new();
}