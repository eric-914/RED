using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class MaximumInPixelsConverter : FieldConverter<IMaximumInPixels>
{
    public MaximumInPixelsConverter() : base(x => x.MaximumInPixels) { }
}
