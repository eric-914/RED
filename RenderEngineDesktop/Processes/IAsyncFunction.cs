using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// An async function has two parts:
    /// What to invoke, and what to do with result when complete.
    /// </summary>
    /// <typeparam name="TResult">The result type</typeparam>
    /// <typeparam name="TPayload">The OnComplete payload type</typeparam>
    public interface IAsyncFunction<TResult, TPayload> : IAsyncOnComplete<TPayload>
    {
        public Task<TResult> Invoke();

        public void InvokeComplete(TResult result);
    }
}
