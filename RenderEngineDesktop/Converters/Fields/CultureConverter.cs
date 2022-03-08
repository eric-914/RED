using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class CultureConverter : FieldConverter<ICulture>
{
    public CultureConverter() : base(x => x.Culture) { }
}

public class ZipFileConverter : FieldConverter<IZipFile>
{
    public ZipFileConverter() : base(x => x.ZipFile) { }
}
