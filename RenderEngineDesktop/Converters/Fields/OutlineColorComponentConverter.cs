using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class OutlineColorComponentConverter : FieldConverter<IOutlineColorComponent>
{
    public OutlineColorComponentConverter() : base(x => x.OutlineColorComponent) { }
}
