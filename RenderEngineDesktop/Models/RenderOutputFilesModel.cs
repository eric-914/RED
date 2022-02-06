using System;
using System.Collections.Generic;

namespace RenderEngineDesktop.Models
{
    public class RenderOutputFilesModel
    {
        public Guid ClientId { get; set; }
        public string Instance { get; set; } = string.Empty;
        public string Environment { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public Guid TemplateInstanceId { get; set; }
        public List<string> OutputFilePaths { get; set; } = new();
    }
}
