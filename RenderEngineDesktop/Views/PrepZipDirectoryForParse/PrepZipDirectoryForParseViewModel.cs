using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Process;

namespace RenderEngineDesktop.Views.PrepZipDirectoryForParse
{
    public class PrepZipDirectoryForParseViewModel : BaseServiceViewModel<PrepZipDirectoryForParseModel>
    {
        public PrepZipDirectoryForParseViewModel() { }

        [Ninject.Inject]
        public PrepZipDirectoryForParseViewModel(ICommands commands)
            : base(x => x.PrepZipDirectoryForParse)
        {
            SetInvoke(commands.PrepZipDirectoryForParseCommand());
        }
    }
}
