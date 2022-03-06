using RenderEngineDesktop.Models.Logging;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace RenderEngineDesktop.Views.Logging
{
    public interface ILogDocumentModel
    {
        FlowDocument Document { get; set; }
        LogShowState Show { get; }

        void AddRange(IEnumerable<ILogEvent> e);
        void Reset();
    }

    public class LogDocumentModel : ILogDocumentModel
    {
        public FlowDocument Document { get; set; } = new();
        public LogShowState Show { get; }

        private readonly ILogger _logger;
        private readonly ILogBlock _block;

        private readonly Dictionary<LogType, Action<ILogEvent>> _handlers;

        public LogDocumentModel(ILogger logger, ILogBlock block, LogShowState show)
        {
            _logger = logger;
            _block = block;
            Show = show;

            _handlers = new Dictionary<LogType, Action<ILogEvent>>
            {
                {LogType.Information, Information},
                {LogType.Error, Error},
                {LogType.Exception, Exception},
            };
        }

        public void Information(ILogEvent e)
        {
            if (Show.Information)
            {
                Add(_block.Information(e));
            }
        }

        public void Error(ILogEvent e)
        {
            if (Show.Errors)
            {
                Add(_block.Error(e));
            }
        }

        public void Exception(ILogEvent e)
        {
            if (Show.Exceptions)
            {
                Add(_block.Exception(e));
            }
        }

        public void Reset()
        {
            Document = new FlowDocument();

            AddRange(_logger.Events);
        }

        public void AddRange(IEnumerable<ILogEvent> list)
        {
            foreach (var e in list)
            {
                Add(e);
            }
        }

        public void Add(ILogEvent e) => _handlers[e.LogType](e);

        private void Add(Block block) => Document.Blocks.Add(block);
    }

    /// <summary>
    /// This is just a placeholder until a valid document model is created.
    /// </summary>
    public class NullLogDocumentModel : ILogDocumentModel
    {
        public FlowDocument Document { get; set; } = new();
        public LogShowState Show { get; } = new();

        public void AddRange(IEnumerable<ILogEvent> e) => throw new NotImplementedException();
        public void Reset() => throw new NotImplementedException();
    }
}
