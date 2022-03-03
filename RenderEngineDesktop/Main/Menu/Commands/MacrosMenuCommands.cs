using RenderEngineDesktop.Commands;
using System.Windows.Input;

namespace RenderEngineDesktop.Main.Menu.Commands;

public class MacrosMenuCommands
{
    public ICommand Run { get; }
    public ICommand Record { get; }
    public ICommand Open { get; }
    public ICommand Save { get; }

    public ICommand Load1 { get; }
    public ICommand Load2 { get; }
    public ICommand Load3 { get; }
    public ICommand Load4 { get; }

    public MacrosMenuCommands(ICommands commands)
    {
        Run = commands.MacrosRun();
        Record = commands.MacrosRecord();
        Open = commands.MacrosOpen();
        Save = commands.MacrosSave();

        Load1 = commands.MacroLoadState();
        Load2 = commands.MacroLoadState();
        Load3 = commands.MacroLoadState();
        Load4 = commands.MacroLoadState();
    }
}
