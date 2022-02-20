using System;

namespace RenderEngineDesktop.Processes
{
    public interface IAsyncOnComplete<TPayload>
    {
        Action<TPayload> OnComplete { get; set; }
    }
}
