using System;
using RenderEngineDesktop.Processes;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

namespace RenderEngineDesktop.Commands.Async;

/// <summary>
/// Execute the given process
/// </summary>
/// <typeparam name="TProcess">The process function type to invoke</typeparam>
/// <typeparam name="TResult">The result type</typeparam>
/// <typeparam name="TPayload">The OnComplete payload type</typeparam>
public class AsyncFunctionCommand<TProcess, TResult, TPayload> : AsyncBaseCommand
where TProcess : IAsyncFunction<TResult, TPayload>
{
    private readonly TProcess _process;

    public AsyncFunctionCommand(TProcess process, Action<TPayload> onComplete)
    {
        _process = process;
        _process.OnComplete = onComplete;
    }

    public override async void Execute(object? o)
    {
        IsBusy = true;

        try
        {
            Task<TResult> task = _process.Invoke();

            TResult result = await task;

            if (task.IsCompletedSuccessfully)
            {
                _process.InvokeComplete(result);
            }
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            MessageBox.Show("Async Function failed.");
        }

        IsBusy = false;
    }
}
