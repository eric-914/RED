using RenderEngineDesktop.Service.Parameters.Groupings;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Process;

public class RenderLeadsModel : ISource, ILeads, IOutputFile
{
    public SourceModel Source { get; } = new();

    public LeadsModel Leads { get; } = new();

    public PathModel OutputFile { get; } = new();
}