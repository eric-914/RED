using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Models.Process;

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
