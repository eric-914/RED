using Microsoft.Win32;
using RenderEngineDesktop.Models.Application;
using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Models.Logging;
using RenderEngineDesktop.Service.Parameters.Models;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Commands.Menu;

public class ConfigurationSaveAsCommand : CanExecuteCommand
{
    private readonly PathModel _file;
    private readonly IConfiguration _configuration;
    private readonly ILogger _logger;
    private readonly FileDialog _dialog;

    public ConfigurationSaveAsCommand(IApplication application, IConfiguration configuration, ILogger logger, SaveFileDialog dialog)
    {
        _configuration = configuration;
        _logger = logger;
        _dialog = dialog;

        _file = application.Model.Paths.Configuration;
    }

    public override void Execute()
    {
        _dialog.Configure(_file.Path, FileExtensions.Json);

        if (_dialog.ShowDialog() == true)
        {
            _file.Path = _dialog.FileName;
            _configuration.Save(_file.Path);

            _logger.LogInformation($"Configuration saved as {_file.Path}.");
        }
    }
}
