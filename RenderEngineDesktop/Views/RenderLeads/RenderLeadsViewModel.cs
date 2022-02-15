using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models;

namespace RenderEngineDesktop.Views.RenderLeads
{
    public class RenderLeadsViewModel : BaseServiceViewModel<RenderLeadsModel>
    {
        public RenderLeadsViewModel() { }

        [Ninject.Inject]
        public RenderLeadsViewModel(ICommands commands, IConfiguration configuration)
        : base(configuration.Model.RenderLeads)
        {
            SetInvoke(commands.RenderLeadsCommand());
        }
    }
}
