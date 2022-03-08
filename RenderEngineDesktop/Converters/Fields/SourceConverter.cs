using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class SourceConverter : FieldConverter<ISource>
{
    public SourceConverter() : base(x => x.Source) { }
}
