using System;
using RenderEngineDesktop.Annotations;
using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;

namespace RenderEngineDesktop.Commands
{
    public class ListEnumeratedFontsCommand : AsyncFunctionCommand<string>
    {
        public ListEnumeratedFontsCommand([NotNull] ListEnumeratedFontsProcess process, Action<string> onComplete) 
            : base(process)
        {
            process.OnComplete = onComplete;
        }
    }
}
