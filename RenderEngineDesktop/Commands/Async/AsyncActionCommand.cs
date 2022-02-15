using RenderEngineDesktop.Processes;
using System.Diagnostics;
using System.Windows;

namespace RenderEngineDesktop.Commands.Async;

/// <summary>
/// Execute the given process
/// </summary>
public class AsyncActionCommand : AsyncBaseCommand
{
    private readonly IAsyncAction _process;

    public AsyncActionCommand(IAsyncAction process)
    {
        _process = process;
    }

    public override async void Execute()
    {
        try
        {
            await _process.Invoke();
        }
        catch (System.Exception e)
        {
            Debug.WriteLine(e.Message);
            MessageBox.Show("Async Action failed.");
        }
    }
}
