using Ninject;
using RenderEngineDesktop.Processes;
using System;
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
    private readonly Action<TPayload> _onComplete;

    private TProcess _process = default!;

    [Inject]
    public TProcess Process
    {
        get => _process;
        set
        {
            _process = value;
            _process.OnComplete = _onComplete;
        }
    }

    public AsyncFunctionCommand(Action<TPayload> onComplete)
    {
        _onComplete = onComplete;
    }

    public override async void Execute(object? o)
    {
        IsBusy = true;

        try
        {
            Logger.LogInformation($"{GetType().Name}.Execute():START");

            Task<TResult> task = Process.Invoke();

            Logger.LogInformation($"{GetType().Name}.Execute():COMPLETE");

            TResult result = await task;

            if (task.IsCompletedSuccessfully)
            {
                Process.InvokeComplete(result);
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
