using RenderEngineDesktop.Commands;
using System.Windows.Input;

namespace RenderEngineDesktop.Main
{
    public class MacrosMenuCommands
    {
        public ICommand Run { get; }
        public ICommand Record { get; }
        public ICommand Open { get; }
        public ICommand Save { get; }

        public MacrosMenuCommands(ICommands commands)
        {
            Run = commands.MacrosRun();
            Record = commands.MacrosRecord();
            Open = commands.MacrosOpen();
            Save = commands.MacrosSave();
        }
    }
}
