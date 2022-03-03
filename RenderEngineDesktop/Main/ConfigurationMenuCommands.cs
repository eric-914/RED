using RenderEngineDesktop.Commands;
using System.Windows.Input;

namespace RenderEngineDesktop.Main
{
    public class ConfigurationMenuCommands
    {
        public ICommand New { get; }
        public ICommand Open { get; }
        public ICommand Save { get; }

        public ConfigurationMenuCommands(ICommands commands)
        {
            New = commands.ConfigurationNew();
            Open = commands.ConfigurationOpen();
            Save = commands.ConfigurationSave();
        }
    }
}
