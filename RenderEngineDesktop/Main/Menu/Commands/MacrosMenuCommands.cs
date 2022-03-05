using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.SavedState;
using System.Windows.Input;

namespace RenderEngineDesktop.Main.Menu.Commands;

public class MacrosMenuCommands
{
    public ICommand Run { get; }
    public ICommand Record { get; }
    public ICommand Open { get; }
    public ICommand Save { get; }

    public SavedStateModel SavedState { get; }

    public MacrosMenuCommands(ICommands commands)
    {
        Run = commands.MacrosRun();
        Record = commands.MacrosRecord();
        Open = commands.MacrosOpen();
        Save = commands.MacrosSave();

        SavedState = new SavedStateModel(commands.MacroLoadState);
    }
}
