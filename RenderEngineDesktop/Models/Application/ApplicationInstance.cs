using RenderEngineDesktop.Models.Configuration;

namespace RenderEngineDesktop.Models.Application
{
    public interface IApplication
    {
        ApplicationModel Model { get; }

        void Load(string? filepath = null);
        void Save(string? filepath = null);
    }

    public class ApplicationInstance : IApplication
    {
        private readonly IApplicationManager _manager;
        private readonly IConfiguration _configuration;
        public ApplicationModel Model { get; private set; } = new();

        public ApplicationInstance(IApplicationManager manager, IConfiguration configuration)
        {
            _manager = manager;
            _configuration = configuration;
        }

        public void Load(string? filepath = null)
        {
            Model = _manager.Load(filepath);
            _configuration.Load(Model.CurrentPath.Configuration);
        }

        public void Save(string? filepath = null)
        {
            _manager.Save(Model, filepath);
            _configuration.Save(Model.CurrentPath.Configuration);
        }
    }
}
