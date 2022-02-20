using System;
using System.Collections.Generic;

namespace RenderEngineDesktop.Service.Parameters.Models
{
    /// <summary>
    /// Common definition for MULTIPLE leads.
    /// </summary>
    public class LeadsModel
    {
        public List<Guid> Ids { get; set; } = new();
    }
}
