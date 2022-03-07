using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Models.Logging;

namespace RenderEngineDesktop.Commands.Menu;

public class ConfigurationSaveCommand : CanExecuteCommand
{
    private readonly IConfiguration _configuration;
    private readonly ILogger _logger;

    public ConfigurationSaveCommand(IConfiguration configuration, ILogger logger)
    {
        _configuration = configuration;
        _logger = logger;
    }

    public override void Execute()
    {
        _configuration.Save();
        _logger.LogInformation("Configuration saved.");
    }
}
