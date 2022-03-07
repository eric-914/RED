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
        public string FilePath { get; set; }

        private readonly IConfigurationPersistence _persistence;

        public ConfigurationManager(IConfigurationPersistence persistence, ISystemInformation information)
        {
            _persistence = persistence;

            //--Define default file path
            FilePath = Path.Join(information.ApplicationFolder(), "configuration.json");
        }

        public ConfigurationModel Load(string? filepath = null)
        {
            if (string.IsNullOrEmpty(filepath)) filepath = FilePath;
            if (File.Exists(filepath)) FilePath = filepath;

            return _persistence.Load(filepath);
        }

        public void Save(ConfigurationModel model, string? filepath = null)
        {
            if (string.IsNullOrEmpty(filepath)) filepath = FilePath;

            _persistence.Save(filepath, model);

            if (File.Exists(filepath)) FilePath = filepath;
        }
    }
}
