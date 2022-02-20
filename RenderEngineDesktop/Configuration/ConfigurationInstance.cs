namespace RenderEngineDesktop.Configuration
{
    /// <summary>
    /// Provides access to the configuration model and it's persistence.
    /// </summary>
    public interface IConfiguration
    {
        ConfigurationModel Model { get; }

        void Load();
        void Save();
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

        public void Load()
        {
            Model = _manager.Load();
        }

        public void Save()
        {
            _manager.Save(Model);
        }
    }
}
