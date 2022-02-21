﻿using RenderEngineDesktop.Commands.Async;
using RenderEngineDesktop.Processes;

namespace RenderEngineDesktop.Commands.Process.Actions
{
    public class PrepZipDirectoryForParseCommand 
        : AsyncActionCommand<PrepZipDirectoryForParseProcess>
    {
        public PrepZipDirectoryForParseCommand(PrepZipDirectoryForParseProcess process) 
            : base(process)
        {
        }
    }
}