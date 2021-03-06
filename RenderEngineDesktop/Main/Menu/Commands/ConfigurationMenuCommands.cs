using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.SavedState;
using System.Windows.Input;

namespace RenderEngineDesktop.Main.Menu.Commands;

public class ConfigurationMenuCommands
{
    public ICommand New { get; }
    public ICommand Open { get; }
    public ICommand Save { get; }
    public ICommand SaveAs { get; }

    public SavedStateModel SavedState { get; }

    public ConfigurationMenuCommands(ICommands commands)
    {
        New = commands.ConfigurationNew();
        Open = commands.ConfigurationOpen();
        Save = commands.ConfigurationSave();
        SaveAs = commands.ConfigurationSaveAs();

        SavedState = new SavedStateModel(commands.ConfigurationLoadState);
    }
}
