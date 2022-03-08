using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Process;

namespace RenderEngineDesktop.Views.RenderLeads
{
    public class RenderLeadsViewModel : BaseServiceViewModel<RenderLeadsModel>
    {
        public RenderLeadsViewModel() { }

        [Ninject.Inject]
        public RenderLeadsViewModel(ICommands commands) 
            : base(x => x.RenderLeads)
        {
            SetInvoke(commands.RenderLeadsCommand());
        }
    }
}
