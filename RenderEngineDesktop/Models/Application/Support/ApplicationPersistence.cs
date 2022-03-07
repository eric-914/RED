using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Models.Application.Support
{
    public interface IApplicationPersistence : IPersistence<ApplicationModel>
    {
    }

    public class ApplicationPersistence : Persistence<ApplicationModel>, IApplicationPersistence
    {
        public ApplicationPersistence(IFactory factory) : base(factory) { }
    }
}
