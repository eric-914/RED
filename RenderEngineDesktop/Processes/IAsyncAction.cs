using System.Threading.Tasks;

namespace RenderEngineDesktop.Processes
{
    /// <summary>
    /// An async action defines what is to be invoked by the async process handlers
    /// </summary>
    public interface IAsyncAction
    {
        public Task Invoke();
    }
}
