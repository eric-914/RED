using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;

namespace RenderEngineDesktop.Commands.Process.Actions
{
    public class RenderOutputFilesCommand 
        : AsyncActionCommand<RenderOutputFilesProcess>
    {
        public RenderOutputFilesCommand(RenderOutputFilesProcess process) 
            : base(process)
        {
        }
    }
}
