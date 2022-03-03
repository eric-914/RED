using System.Windows;

namespace RenderEngineDesktop.Commands.Menu;

public class MacrosRecordCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Macros.Record");
    }
}
