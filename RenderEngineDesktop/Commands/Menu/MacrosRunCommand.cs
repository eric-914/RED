using System.Windows;

namespace RenderEngineDesktop.Commands.Menu;

public class MacrosRunCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Macros.Run");
    }
}

public class MacrosRecordCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Macros.Record");
    }
}

public class MacrosOpenCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Macros.Open");
    }
}

public class MacrosSaveCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Macros.Save");
    }
}
