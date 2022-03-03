using System.Windows;

namespace RenderEngineDesktop.Commands.Menu;

public class ConfigurationSaveCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Configuration.Save");
    }
}