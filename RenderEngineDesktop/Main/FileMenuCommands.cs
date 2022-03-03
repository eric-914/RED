using System.Windows.Input;
using RenderEngineDesktop.Commands;

namespace RenderEngineDesktop.Main;

public class FileMenuCommands
{
    public ICommand Exit { get; }

    public FileMenuCommands(ICommands commands)
    {
        Exit = commands.FileExit();
    }
}