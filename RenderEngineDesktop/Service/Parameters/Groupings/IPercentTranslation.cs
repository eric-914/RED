using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Service.Parameters.Groupings;

public interface IPercentTranslation
{
    PointModel<float> PercentTranslation { get; }
}
