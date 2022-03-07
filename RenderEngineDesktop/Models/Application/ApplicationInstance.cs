using RenderEngineDesktop.Models.Configuration;

namespace RenderEngineDesktop.Models.Application
{
    public interface IApplication
    {
        ApplicationModel Model { get; }

        void Load();
        void Save();
    }

    public class ApplicationInstance : IApplication
    {
        private readonly IApplicationManager _manager;
        private readonly IConfiguration _configuration;

        public ApplicationModel Model { get; private set; }

        public ApplicationInstance(ApplicationModel model, IApplicationManager manager, IConfiguration configuration)
        {
            Model = model;
            _manager = manager;
            _configuration = configuration;
        }

        public void Load()
        {
            Model = _manager.Load();
            _configuration.Load(Model.Paths.Configuration.Path);
        }

        public void Save()
        {
            _manager.Save(Model);
            _configuration.Save(Model.Paths.Configuration.Path);
        }
    }
}
