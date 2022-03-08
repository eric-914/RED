using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class LeadsConverter : FieldConverter<ILeads>
{
    public LeadsConverter() : base(x => x.Leads) { }
}
