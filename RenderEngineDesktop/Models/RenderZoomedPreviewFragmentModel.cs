using RenderEngineDesktop.Models.Common;

namespace RenderEngineDesktop.Models
{
    public class RenderZoomedPreviewFragmentModel
    {
        public SourceModel Source { get; } = new();

        public TemplateModel Template { get; } = new();

        public SizeModel<int> MaximumInPixels { get; } = new(0, 0);
        
        public RgbModel OutlineColorComponent { get; } = new();

        public PointModel<float> PercentTranslation { get; } = new(0, 0);

        public SizeModel<float> Percentage { get; } = new(0, 0);
    }
}
