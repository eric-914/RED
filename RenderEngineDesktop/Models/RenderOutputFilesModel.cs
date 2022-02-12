﻿using RenderEngineDesktop.Models.Common;

namespace RenderEngineDesktop.Models
{
    public class RenderOutputFilesModel
    {
        public SourceModel Source { get; } = new();

        public TemplateModel Template { get; } = new();

        public PathsModel OutputFiles { get; } = new();
    }
}
