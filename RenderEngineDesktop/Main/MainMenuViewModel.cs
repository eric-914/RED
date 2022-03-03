using Ninject;

namespace RenderEngineDesktop.Main
{
    public class MainMenuViewModel
    {
        public FileMenuCommands File { get; } = default!;

        public MainMenuViewModel() { }

        [Inject]
        public MainMenuViewModel(FileMenuCommands file)
        {
            File = file;
        }
    }
}
