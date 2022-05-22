using RenderEngineDesktop.Service.Parameters.Groupings;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Process
{
    /// <summary>
    /// This is a generic process model to give the RenderEngineFields something to bind to.
    /// </summary>
    public class GenericProcessModel : ISource, ITemplate, IOutlineColorComponent, IPercentTranslation, IPercentage, IZipFile, ILeads, IMaximumInPixels, IOutputFile, IOutputFiles, IWatermark
    {
        public SourceModel Source { get; } = new();
        public TemplateModel Template { get; } = new();
        public RgbModel OutlineColorComponent { get; } = new();
        public PointModel<float> PercentTranslation { get; } = new();
        public SizeModel<float> Percentage { get; } = new();
        public PathModel ZipFile { get; } = new();
        public LeadsModel Leads { get; } = new();
        public SizeModel<int> MaximumInPixels { get; } = new();
        public PathModel OutputFile { get; } = new();
        public PathsModel OutputFiles { get; } = new();
        public WatermarkModel Watermark { get; } = new();
    }
}
