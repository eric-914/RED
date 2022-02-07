using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// An async function has two parts:
    /// What to invoke, and what to do with result when complete.
    /// </summary>
    /// <typeparam name="T">The result type</typeparam>
    public interface IAsyncFunction<T>
    {
        public Task<T> Invoke();

        public void InvokeComplete(T result);
    }
}
