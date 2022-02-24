﻿using Ninject;
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
    [Inject] 
    public TProcess Process { get; set; } = default!;

    public override async void Execute(object? o)
    {
        IsBusy = true;

        try
        {
            Logger.LogInformation($"{GetType().Name}.Execute():START");

            await Process.Invoke();

            Logger.LogInformation($"{GetType().Name}.Execute():COMPLETE");
        }
        catch (System.Exception e)
        {
            Debug.WriteLine(e.Message);
            MessageBox.Show("Async Action failed.");
        }

        IsBusy = false;
    }
}
