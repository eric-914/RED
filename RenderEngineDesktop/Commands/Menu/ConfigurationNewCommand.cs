using System.Windows;

namespace RenderEngineDesktop.Commands.Menu
{
    public class ConfigurationNewCommand : CanExecuteCommand
    {
        public override void Execute()
        {
            MessageBox.Show("Configuration.New");
        }
    }
}
