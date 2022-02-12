using RenderEngineDesktop.Models.Common;

namespace RenderEngineDesktop.Models
{
    public class RenderWaterMarkedPreviewModel
    {
        public SourceModel Source { get; } = new();

        public TemplateModel Template { get; } = new();

        public SizeModel<int> MaximumInPixels { get; } = new(0, 0);

        public RgbModel OutlineColorComponent { get; } = new();
    }
}
