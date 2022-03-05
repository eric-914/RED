using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Models.Configuration.Support
{
    public interface IConfigurationPersistence : IPersistence<ConfigurationModel>
    {
    }

    internal class ConfigurationPersistence : Persistence<ConfigurationModel>, IConfigurationPersistence
    {
        public ConfigurationPersistence(IFactory factory) : base(factory) { }
    }
}
