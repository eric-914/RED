using System.ComponentModel;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Models.Configuration
{
    /// <summary>
    /// Provides access to the configuration model and it's persistence.
    /// </summary>
    public interface IConfiguration : INotifyPropertyChanged
    {
        ConfigurationModel Model { get; }

        void Load(string? filepath = null);
        void Save(string? filepath = null);
        void New();
    }

    /// <summary>
    /// The root container of the configuration model
    /// </summary>
    public class ConfigurationInstance : NotifyModel, IConfiguration
    {
        private readonly IConfigurationManager _manager;

        private ConfigurationModel _model = new();
        public ConfigurationModel Model
        {
            get => _model;
            private set => Set(_model == value, () => _model = value);
        }

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

        public void New()
        {
            Model = new ConfigurationModel();
        }
    }

    public class NullConfiguration : NotifyModel, IConfiguration
    {
        public ConfigurationModel Model => null!;

        public void Load(string? filepath = null) => throw new System.NotImplementedException();
        public void Save(string? filepath = null) => throw new System.NotImplementedException();
        public void New() => throw new System.NotImplementedException();
    }
}
