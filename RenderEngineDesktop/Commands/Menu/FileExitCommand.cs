using System.Windows;

namespace RenderEngineDesktop.Commands.Menu
{
    public class FileExitCommand : CanExecuteCommand
    {
        public override void Execute()
        {
            Application.Current.MainWindow?.Close();
        }
    }
}
