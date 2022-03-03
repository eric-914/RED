using System.Windows;

namespace RenderEngineDesktop.Commands.SavedState
{
    public class MacroLoadStateCommand : SavedStateCommand
    {
        public override void Execute(object? parameter)
        {
            MessageBox.Show($"Macros.LoadState({Path})");
        }
    }
}
