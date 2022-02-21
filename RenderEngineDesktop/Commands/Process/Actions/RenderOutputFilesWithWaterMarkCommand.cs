using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;

namespace RenderEngineDesktop.Commands.Process.Actions
{
    public class RenderOutputFilesWithWatermarkCommand 
        : AsyncActionCommand<RenderOutputFilesWithWatermarkProcess>
    {
        public RenderOutputFilesWithWatermarkCommand(RenderOutputFilesWithWatermarkProcess process) 
            : base(process)
        {
        }
    }
}
