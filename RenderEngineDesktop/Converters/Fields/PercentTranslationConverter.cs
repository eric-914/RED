using RenderEngineDesktop.Service.Parameters.Groupings;

namespace RenderEngineDesktop.Converters.Fields;

public class PercentTranslationConverter : FieldConverter<IPercentTranslation>
{
    public PercentTranslationConverter() : base(x => x.PercentTranslation) { }
}
