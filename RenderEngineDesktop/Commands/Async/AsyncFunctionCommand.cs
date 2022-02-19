using RenderEngineDesktop.Processes;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

namespace RenderEngineDesktop.Commands.Async;

/// <summary>
/// Execute the given process
/// </summary>
/// <typeparam name="T">The result type</typeparam>
public class AsyncFunctionCommand<T> : AsyncBaseCommand
{
    private readonly IAsyncFunction<T> _process;

    public AsyncFunctionCommand(IAsyncFunction<T> process)
    {
        _process = process;
    }

    public override async void Execute(object? o)
    {
        IsBusy = true;

        try
        {
            Task<T> task = _process.Invoke();

            T result = await task;

            if (task.IsCompletedSuccessfully)
            {
                _process.InvokeComplete(result);
            }
        }
        catch (System.Exception e)
        {
            Debug.WriteLine(e.Message);
            MessageBox.Show("Async Function failed.");
        }

        IsBusy = false;
    }
}
