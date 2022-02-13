using System.IO;
using RenderEngineDesktop.Configuration.Support;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Configuration
{
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
