using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;
using System;

namespace RenderEngineDesktop.Commands.Process.Functions
{
    public class RenderPreviewHtml5Command 
        : AsyncStringFunctionCommand<RenderPreviewHtml5Process>
    {
        public RenderPreviewHtml5Command(RenderPreviewHtml5Process process, Action<string> onComplete) 
            : base(onComplete)
        {
        }
    }
}
