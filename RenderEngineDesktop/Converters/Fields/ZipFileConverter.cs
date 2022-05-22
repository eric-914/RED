using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class ZipFileConverter : FieldConverter<IZipFile>
{
    public ZipFileConverter() : base(x => x.ZipFile) { }
}
