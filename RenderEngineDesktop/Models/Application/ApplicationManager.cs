using RenderEngineDesktop.Models.Application.Support;
using RenderEngineDesktop.Support;
using System.IO;

namespace RenderEngineDesktop.Models.Application
{
    public interface IApplicationManager
    {
        ApplicationModel Load();
        void Save(ApplicationModel model);
    }

    public class ApplicationManager : IApplicationManager
    {
        public string FilePath { get; }

        private readonly IApplicationPersistence _persistence;

        public ApplicationManager(IApplicationPersistence persistence, ISystemInformation information)
        {
            _persistence = persistence;

            //--Define the application configuration file path (fixed location)
            FilePath = Path.Join(information.ApplicationFolder(), "RED.json");
        }

        public ApplicationModel Load()
        {
            return _persistence.Load(FilePath);
        }

        public void Save(ApplicationModel model)
        {
            _persistence.Save(FilePath, model);
        }
    }
}
