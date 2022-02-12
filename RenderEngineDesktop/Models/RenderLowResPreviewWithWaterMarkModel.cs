using RenderEngineDesktop.Models.Common;

namespace RenderEngineDesktop.Models
{
    public class RenderLowResPreviewWithWaterMarkModel
    {
        public SourceModel Source { get; } = new();

        public TemplateModel Template { get; } = new();

        public PathModel OutputFile { get; set; } = new();

        public WaterMarkModel WaterMark { get; } = new();
    }
}
