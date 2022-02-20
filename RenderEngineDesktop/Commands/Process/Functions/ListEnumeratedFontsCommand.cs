using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;
using System;

namespace RenderEngineDesktop.Commands.Process.Functions
{
    public class ListEnumeratedFontsCommand 
        : AsyncStringFunctionCommand<ListEnumeratedFontsProcess>
    {
        public ListEnumeratedFontsCommand(ListEnumeratedFontsProcess process, Action<string> onComplete) 
            : base(process, onComplete)
        {
        }
    }
}
