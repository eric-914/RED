using System.Threading.Tasks;
using System.Windows;
using RenderEngineDesktop.Processes;

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

    public override async void Execute()
    {
        Task<T> task = _process.Invoke();

        try
        {
            T result = await task;

            if (task.IsCompletedSuccessfully)
            {
                _process.InvokeComplete(result);
            }
        }
        catch (System.Exception)
        {
            MessageBox.Show("Async Function failed.");
        }
    }
}
