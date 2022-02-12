using RenderEngineDesktop.Models.Common;

namespace RenderEngineDesktop.Models
{
    public class RenderPreviewHtml5Model
    {
        public SourceModel Source { get; } = new();

        public TemplateModel Template { get; } = new();

        public CultureModel Culture { get; } = new();
    }
}
