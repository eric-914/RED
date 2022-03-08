using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class OutputFilesConverter : FieldConverter<IOutputFiles>
{
    public OutputFilesConverter() : base(x => x.OutputFiles) { }
}
