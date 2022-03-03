using System.Windows;

namespace RenderEngineDesktop.Commands.Menu;

public class MacrosOpenCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Macros.Open");
    }
}
