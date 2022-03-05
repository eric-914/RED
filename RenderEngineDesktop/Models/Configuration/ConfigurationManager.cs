using System.IO;
using RenderEngineDesktop.Models.Configuration.Support;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Models.Configuration
{
    /// <summary>
    /// Manages the load/save of the configuration model
    /// </summary>
    internal interface IConfigurationManager
    {
        ConfigurationModel Load(string? filepath = null);
        void Save(ConfigurationModel model, string? filepath = null);
    }

    internal class ConfigurationManager : IConfigurationManager
    {
        public const string FileName = "configuration.json";

        private readonly ISystemInformation _information;
        private readonly IConfigurationPersistence _persistence;
        
        public ConfigurationManager(ISystemInformation information, IConfigurationPersistence persistence)
        {
            _information = information;
            _persistence = persistence;
        }

        public ConfigurationModel Load(string? filepath = null)
        {
            if (string.IsNullOrEmpty(filepath)) filepath = FilePath;
            return _persistence.Load(filepath);
        }

        public void Save(ConfigurationModel model, string? filepath = null)
        {
            if (string.IsNullOrEmpty(filepath)) filepath = FilePath;
            _persistence.Save(filepath, model);
        }

        private string FilePath => Path.Join(_information.ApplicationFolder(), FileName);
    }
}
