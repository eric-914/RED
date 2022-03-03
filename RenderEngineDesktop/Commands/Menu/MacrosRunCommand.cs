using System.Windows;

namespace RenderEngineDesktop.Commands.Menu;

public class MacrosRunCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Macros.Run");
    }
}