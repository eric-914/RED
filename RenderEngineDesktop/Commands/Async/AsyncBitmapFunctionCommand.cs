using RenderEngineDesktop.Processes;
using System;
using System.Windows.Media;

namespace RenderEngineDesktop.Commands.Async
{
    /// <summary>
    /// A specific implementation of the AsyncFunctionCommand for the Bitmap function processes.
    /// </summary>
    /// <remarks>
    /// Bitmap processes call a function that returns a byte[] array.
    /// This array eventually gets converted to WPF's ImageSource.
    /// </remarks>
    public class AsyncBitmapFunctionCommand<TProcess> 
        : AsyncFunctionCommand<TProcess, byte[]?, ImageSource>
        where TProcess : IAsyncFunction<byte[]?, ImageSource>
    {
        public AsyncBitmapFunctionCommand(Action<ImageSource> onComplete) 
            : base(onComplete)
        {
        }
    }
}
