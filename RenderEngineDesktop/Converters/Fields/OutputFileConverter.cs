using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class OutputFileConverter : FieldConverter<IOutputFile>
{
    public OutputFileConverter() : base(x => x.OutputFile) { }
}
