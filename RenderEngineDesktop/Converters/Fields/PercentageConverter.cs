using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class PercentageConverter : FieldConverter<IPercentage>
{
    public PercentageConverter() : base(x => x.Percentage) { }
}
