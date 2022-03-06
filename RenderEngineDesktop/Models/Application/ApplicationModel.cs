using RenderEngineDesktop.Views.Logging;

namespace RenderEngineDesktop.Models.Application
{
    public class ApplicationModel
    {
        public ApplicationPathModel CurrentPath { get; } = new();
        public ApplicationWindowModel Window { get; } = new();

        public LogShowState LogShowState { get; }

        public ApplicationModel(LogShowState show)
        {
            LogShowState = show;
        }
    }
}
