using System.Collections.Generic;
using System.ComponentModel.Design;

namespace RenderEngineDesktop.Main
{
    public class MenuCommands : List<MenuCommand>
    {
        public FileMenuCommands File { get; }

        public MenuCommands(FileMenuCommands file)
        {
            File = file;
        }
    }
}
