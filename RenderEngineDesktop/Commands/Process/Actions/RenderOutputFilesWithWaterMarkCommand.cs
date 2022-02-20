using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;

namespace RenderEngineDesktop.Commands.Process.Actions
{
    public class RenderOutputFilesWithWaterMarkCommand 
        : AsyncActionCommand<RenderOutputFilesWithWaterMarkProcess>
    {
        public RenderOutputFilesWithWaterMarkCommand(RenderOutputFilesWithWaterMarkProcess process) 
            : base(process)
        {
        }
    }
}
