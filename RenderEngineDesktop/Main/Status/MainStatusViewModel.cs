using Ninject;
using RenderEngineDesktop.Models.Application;
using RenderEngineDesktop.Models.Macros;

namespace RenderEngineDesktop.Main.Status
{
    public class MainStatusViewModel
    {
        public string Message { get; } = "Status message here...";

        public MacroState MacroState { get; } = new();

        public ApplicationWindowModel Window { get; } = default!;


        public MainStatusViewModel() { }

        [Inject]
        public MainStatusViewModel(IApplication application)
        {
            Window = application.Model.Window;
        }
    }
}
