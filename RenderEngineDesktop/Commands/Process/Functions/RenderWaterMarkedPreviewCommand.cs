using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;
using System;
using System.Windows.Media;

namespace RenderEngineDesktop.Commands.Process.Functions
{
    public class RenderWaterMarkedPreviewCommand 
        : AsyncBitmapFunctionCommand<RenderWaterMarkedPreviewProcess>
    {
        public RenderWaterMarkedPreviewCommand(RenderWaterMarkedPreviewProcess process, Action<ImageSource> onComplete) 
            : base(process, onComplete)
        {
        }
    }
}
