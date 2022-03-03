using Ninject;
using RenderEngineDesktop.Main.Menu.Commands;

namespace RenderEngineDesktop.Main.Menu;

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
