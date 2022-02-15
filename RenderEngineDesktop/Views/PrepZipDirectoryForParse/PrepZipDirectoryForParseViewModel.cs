using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models;

namespace RenderEngineDesktop.Views.PrepZipDirectoryForParse
{
    public class PrepZipDirectoryForParseViewModel : BaseServiceViewModel<PrepZipDirectoryForParseModel>
    {
        public PrepZipDirectoryForParseViewModel() { }

        [Ninject.Inject]
        public PrepZipDirectoryForParseViewModel(ICommands commands, IConfiguration configuration)
        : base(configuration.Model.PrepZipDirectoryForParse)
        {
            SetInvoke(commands.PrepZipDirectoryForParseCommand());
        }
    }
}
