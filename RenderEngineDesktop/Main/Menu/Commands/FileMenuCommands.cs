using RenderEngineDesktop.Commands;
using System.Windows.Input;

namespace RenderEngineDesktop.Main.Menu.Commands;

public class FileMenuCommands
{
    public ICommand Exit { get; }

    public FileMenuCommands(ICommands commands)
    {
        Exit = commands.FileExit();
    }
}
