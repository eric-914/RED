using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Service.Parameters.Groupings;

public interface IMaximumInPixels
{
    SizeModel<int> MaximumInPixels { get; }
}
