using Ninject;

namespace RenderEngineDesktop.Main
{
    public class MainMenuViewModel
    {
        public FileMenuCommands File { get; } = default!;
        public ConfigurationMenuCommands Configuration { get; } = default!;
        public MacrosMenuCommands Macros { get; } = default!;

        public MainMenuViewModel() { }

        [Inject]
        public MainMenuViewModel(FileMenuCommands file, ConfigurationMenuCommands configuration, MacrosMenuCommands macros)
        {
            File = file;
            Configuration = configuration;
            Macros = macros;
        }
    }
}
