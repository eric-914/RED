using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class WatermarkConverter : FieldConverter<IWatermark>
{
    public WatermarkConverter() : base(x => x.Watermark) { }
}
