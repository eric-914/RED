namespace RenderEngineDesktop.Configuration
{
    public interface IConfiguration
    {
        ConfigurationModel Model { get; }

        void Load();
        void Save();
    }

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
