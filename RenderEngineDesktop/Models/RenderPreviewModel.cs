using System;

namespace RenderEngineDesktop.Models
{
    public class RenderPreviewModel
    {
        public Guid ClientId { get; set; }
        public string Instance { get; set; } = string.Empty;
        public string Environment { get; set; } = "DEV";
        public string Key { get; set; } = "NsiDb";
        public Guid TemplateInstanceId { get; set; }
        public int MaximumWidthInPixels { get; set; }
        public int MaximumHeightInPixels { get; set; }
        public int OutlineColorRedComponent { get; set; } = -1;
        public int OutlineColorGreenComponent { get; set; } = -1;
        public int OutlineColorBlueComponent { get; set; } = -1;
    }
}
