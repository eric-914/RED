using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;
using System;
using System.Windows.Media;

namespace RenderEngineDesktop.Commands.Process.Functions
{
    public class RenderPreviewCommand 
        : AsyncBitmapFunctionCommand<RenderPreviewProcess>
    {
        public RenderPreviewCommand(RenderPreviewProcess process, Action<ImageSource> onComplete) 
            : base(onComplete)
        {
        }
    }
}
