using System.Windows;

namespace RenderEngineDesktop.Commands.Menu;

public class MacrosSaveAsCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Macros.SaveAs");
    }
}