using System.Collections.Generic;

namespace RenderEngineDesktop.Service.Parameters.Models;

/// <summary>
/// Common definition for MULTIPLE file paths.
/// </summary>
public class PathsModel
{
    public List<string> Paths { get; set; } = new();
}