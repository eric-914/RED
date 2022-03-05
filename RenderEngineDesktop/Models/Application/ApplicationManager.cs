using RenderEngineDesktop.Models.Application.Support;
using RenderEngineDesktop.Support;
using System.IO;

namespace RenderEngineDesktop.Models.Application
{
    public interface IApplicationManager
    {
        ApplicationModel Load(string? filepath = null);
        void Save(ApplicationModel model, string? filepath = null);
    }

    public class ApplicationManager : IApplicationManager
    {
        public const string FileName = "RED.json";

        private readonly ISystemInformation _information;
        private readonly IApplicationPersistence _persistence;

        public ApplicationManager(ISystemInformation information, IApplicationPersistence persistence)
        {
            _information = information;
            _persistence = persistence;
        }

        public ApplicationModel Load(string? filepath = null)
        {
            if (string.IsNullOrEmpty(filepath)) filepath = FilePath;
            return _persistence.Load(filepath);
        }

        public void Save(ApplicationModel model, string? filepath = null)
        {
            if (string.IsNullOrEmpty(filepath)) filepath = FilePath;
            _persistence.Save(filepath, model);
        }

        private string FilePath => Path.Join(_information.ApplicationFolder(), FileName);

    }
}
