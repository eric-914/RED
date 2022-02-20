using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Service.Parameters.Groupings;

public interface IPercentage
{
    SizeModel<float> Percentage { get; }
}
