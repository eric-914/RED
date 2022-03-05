﻿using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Models.Process;

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
