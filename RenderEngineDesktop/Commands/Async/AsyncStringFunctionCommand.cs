using RenderEngineDesktop.Processes;
using System;

namespace RenderEngineDesktop.Commands.Async
{
    /// <summary>
    /// A specific implementation of the AsyncFunctionCommand for string function processes.
    /// </summary>
    public class AsyncStringFunctionCommand<TProcess> 
        : AsyncFunctionCommand<TProcess, string, string> 
        where TProcess : IAsyncFunction<string, string>
    {
        public AsyncStringFunctionCommand(Action<string> onComplete) 
            : base(onComplete)
        {
        }
    }
}
