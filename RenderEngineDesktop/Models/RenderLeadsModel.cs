using RenderEngineDesktop.Models.Common;

namespace RenderEngineDesktop.Models
{
    public class RenderLeadsModel
    {
        public SourceModel Source { get; } = new();

        public LeadsModel Leads { get; } = new();

        public PathModel OutputFile { get; } = new();
    }
}
