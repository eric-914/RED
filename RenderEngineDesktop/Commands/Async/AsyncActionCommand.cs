using RenderEngineDesktop.Processes;
using System.Diagnostics;
using System.Windows;

namespace RenderEngineDesktop.Commands.Async;

/// <summary>
/// Execute the given process
/// </summary>
/// <typeparam name="TProcess">The process action type to invoke</typeparam>
public class AsyncActionCommand<TProcess> : AsyncBaseCommand
where TProcess : IAsyncAction
{
    private readonly TProcess _process;

    public AsyncActionCommand(TProcess process)
    {
        _process = process;
    }

    public override async void Execute(object? o)
    {
        IsBusy = true;

        try
        {
            await _process.Invoke();
        }
        catch (System.Exception e)
        {
            Debug.WriteLine(e.Message);
            MessageBox.Show("Async Action failed.");
        }

        IsBusy = false;
    }
}
