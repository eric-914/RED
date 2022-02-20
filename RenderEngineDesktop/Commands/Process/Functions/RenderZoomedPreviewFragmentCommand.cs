using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;
using System;
using System.Windows.Media;

namespace RenderEngineDesktop.Commands.Process.Functions
{
    public class RenderZoomedPreviewFragmentCommand 
        : AsyncBitmapFunctionCommand<RenderZoomedPreviewFragmentProcess>
    {
        public RenderZoomedPreviewFragmentCommand(RenderZoomedPreviewFragmentProcess process, Action<ImageSource> onComplete) 
            : base(process, onComplete)
        {
        }
    }
}
