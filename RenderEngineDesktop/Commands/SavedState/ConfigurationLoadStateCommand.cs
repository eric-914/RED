using System.Windows;
using RenderEngineDesktop.Configuration;

namespace RenderEngineDesktop.Commands.SavedState
{
    public class ConfigurationLoadStateCommand : SavedStateCommand
    {
        private readonly IConfiguration _configuration;

        public ConfigurationLoadStateCommand(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public override void Execute(object? parameter)
        {
            MessageBox.Show($"Configuration.LoadState({Path})");
            //_configuration.Load(Path);
        }
    }
}
