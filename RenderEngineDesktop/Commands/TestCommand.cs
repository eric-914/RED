using RenderEngineDesktop.Dialogs;
using RenderEngineDesktop.Support;
using System;
using System.IO;

namespace RenderEngineDesktop.Commands
{
    /// <summary>
    /// This is just a test class
    /// </summary>
    internal class TestCommand : CanExecuteCommand
    {
        private readonly IDialogManager _dialog;
        private readonly ISystemInformation _system;

        public TestCommand(IDialogManager dialog, ISystemInformation system)
        {
            _dialog = dialog;
            _system = system;
        }

        public override void Execute()
        {
            _dialog
                .ShowPathError(
                    new Exception("Invalid write permissions"),
                    Path.Combine(_system.ApplicationFolder(), "config.json"),
                    "An error occurred while trying to save the file:");
        }
    }
}
