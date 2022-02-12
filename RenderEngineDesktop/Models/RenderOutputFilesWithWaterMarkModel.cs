using RenderEngineDesktop.Models.Common;

namespace RenderEngineDesktop.Models
{
    public class RenderOutputFilesWithWaterMarkModel
    {
        public SourceModel Source { get; } = new();

        public TemplateModel Template { get; } = new();

        public PathsModel OutputFiles { get; } = new();

        public WaterMarkModel WaterMark { get; } = new();
    }
}
