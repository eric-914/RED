using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;
using System;
using System.Windows.Media;

namespace RenderEngineDesktop.Commands.Process.Functions
{
    public class RenderWatermarkedPreviewCommand 
        : AsyncBitmapFunctionCommand<RenderWatermarkedPreviewProcess>
    {
        public RenderWatermarkedPreviewCommand(RenderWatermarkedPreviewProcess process, Action<ImageSource> onComplete) 
            : base(process, onComplete)
        {
        }
    }
}
