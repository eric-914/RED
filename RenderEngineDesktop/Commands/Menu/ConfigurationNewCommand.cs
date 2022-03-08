using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Models.Logging;

namespace RenderEngineDesktop.Commands.Menu;

public class ConfigurationNewCommand : CanExecuteCommand
{
    private readonly IConfiguration _configuration;
    private readonly ILogger _logger;

    public ConfigurationNewCommand(IConfiguration configuration, ILogger logger)
    {
        _configuration = configuration;
        _logger = logger;
    }

    public override void Execute()
    {
        _configuration.New();
        _logger.LogInformation("Configuration has been reset.");
    }
}
