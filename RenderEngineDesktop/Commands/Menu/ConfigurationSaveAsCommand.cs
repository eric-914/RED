using System.Windows;

namespace RenderEngineDesktop.Commands.Menu;

public class ConfigurationSaveAsCommand : CanExecuteCommand
{
    public override void Execute()
    {
        MessageBox.Show("Configuration.SaveAs");
    }
}