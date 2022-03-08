using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class TemplateConverter : FieldConverter<ITemplate>
{
    public TemplateConverter() : base(x => x.Template) { }
}
