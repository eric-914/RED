using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;

namespace RenderEngineDesktop.Commands.Process.Actions
{
    public class RenderLeadsCommand 
        : AsyncActionCommand<RenderLeadsProcess>
    {
        public RenderLeadsCommand(RenderLeadsProcess process) 
            : base(process)
        {
        }
    }
}
