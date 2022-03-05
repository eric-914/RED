namespace RenderEngineDesktop.Models.Configuration
{
    /// <summary>
    /// Provides access to the configuration model and it's persistence.
    /// </summary>
    public interface IConfiguration
    {
        ConfigurationModel Model { get; }

        void Load(string? filepath = null);
        void Save(string? filepath = null);
    }

    /// <summary>
    /// The root container of the configuration model
    /// </summary>
    internal class ConfigurationInstance : IConfiguration
    {
        private readonly IConfigurationManager _manager;

        public ConfigurationModel Model { get; private set; } = new ();

        public ConfigurationInstance(IConfigurationManager manager)
        {
            _manager = manager;
        }

        public void Load(string? filepath = null)
        {
            Model = _manager.Load(filepath);
        }

        public void Save(string? filepath = null)
        {
            _manager.Save(Model, filepath);
        }
    }
}
