using RenderEngineDesktop.Processes;

namespace RenderEngineDesktop.Commands.Async
{
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
            await _process.Invoke();
        }
    }
}
