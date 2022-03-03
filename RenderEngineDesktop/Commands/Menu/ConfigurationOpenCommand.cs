using System.Windows;

namespace RenderEngineDesktop.Commands.Menu;

public class ConfigurationOpenCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Configuration.Open");
    }
}
