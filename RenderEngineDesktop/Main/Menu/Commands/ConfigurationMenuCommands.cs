using RenderEngineDesktop.Commands;
using System.Windows.Input;

namespace RenderEngineDesktop.Main.Menu.Commands;

public class ConfigurationMenuCommands
{
    public ICommand New { get; }
    public ICommand Open { get; }
    public ICommand Save { get; }

    public ICommand Load1 { get; }
    public ICommand Load2 { get; }
    public ICommand Load3 { get; }
    public ICommand Load4 { get; }

    public ConfigurationMenuCommands(ICommands commands)
    {
        New = commands.ConfigurationNew();
        Open = commands.ConfigurationOpen();
        Save = commands.ConfigurationSave();

        Load1 = commands.ConfigurationLoadState();
        Load2 = commands.ConfigurationLoadState();
        Load3 = commands.ConfigurationLoadState();
        Load4 = commands.ConfigurationLoadState();
    }
}
