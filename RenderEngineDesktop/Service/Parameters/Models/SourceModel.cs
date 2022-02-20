using System;

namespace RenderEngineDesktop.Service.Parameters.Models
{
    /// <summary>
    /// Every RES method includes this source/lookup information
    /// </summary>
    public class SourceModel
    {
        public Guid ClientId { get; set; }

        public string Instance { get; set; } = string.Empty;
        public string Environment { get; set; } = string.Empty;
        public string Key { get; set; } = "NsiDb";
    }
}
