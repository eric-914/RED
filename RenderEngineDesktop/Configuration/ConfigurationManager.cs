using RenderEngineDesktop.Configuration.Support;
using RenderEngineDesktop.Support;
using System.IO;

namespace RenderEngineDesktop.Configuration
{
    /// <summary>
    /// Manages the load/save of the configuration model
    /// </summary>
    internal interface IConfigurationManager
    {
        ConfigurationModel Load();
        void Save(ConfigurationModel model);
    }

    internal class ConfigurationManager : IConfigurationManager
    {
        private readonly ISystemInformation _information;
        private readonly IConfigurationPersistence _persistence;

        public const string FileName = "configuration.json";

        public ConfigurationManager(ISystemInformation information, IConfigurationPersistence persistence)
        {
            _information = information;
            _persistence = persistence;
        }

        public ConfigurationModel Load()
        {
            return _persistence.Load(FilePath);
        }

        public void Save(ConfigurationModel model)
        {
            _persistence.Save(FilePath, model);
        }

        private string FilePath => Path.Join(_information.ApplicationFolder(), FileName);
    }
}
