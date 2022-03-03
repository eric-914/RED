using System.Windows;

namespace RenderEngineDesktop.Commands.Menu;

public class MacrosSaveCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Macros.Save");
    }
}
