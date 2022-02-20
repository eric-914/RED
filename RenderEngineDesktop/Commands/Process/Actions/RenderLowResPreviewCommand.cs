using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;

namespace RenderEngineDesktop.Commands.Process.Actions
{
    public class RenderLowResPreviewCommand 
        : AsyncActionCommand<RenderLowResPreviewProcess>
    {
        public RenderLowResPreviewCommand(RenderLowResPreviewProcess process) 
            : base(process)
        {
        }
    }
}
