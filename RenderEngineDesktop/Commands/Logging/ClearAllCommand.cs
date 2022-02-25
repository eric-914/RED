using RenderEngineDesktop.Models.Logging;

namespace RenderEngineDesktop.Commands.Logging
{
    public class ClearAllCommand : CanExecuteCommand
    {
        private readonly ILogger _logger;

        public ClearAllCommand(ILogger logger)
        {
            _logger = logger;
        }

        public override void Execute()
        {
            _logger.Events.Clear();
        }
    }
}
