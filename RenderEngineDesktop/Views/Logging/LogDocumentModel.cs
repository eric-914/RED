using System;
using System.Collections.Generic;
using System.Windows.Documents;
using RenderEngineDesktop.Models.Logging;

namespace RenderEngineDesktop.Views.Logging
{
    public interface ILogDocumentModel
    {
        FlowDocument Document { get; set; }
        LogShowState Show { get; }

        void Information(ILogEvent e);
        void Error(ILogEvent e);
        void Exception(ILogEvent e);

        void Add(ILogEvent e);
        void AddRange(IEnumerable<ILogEvent> e);
        void Reset();
    }

    public class LogDocumentModel : ILogDocumentModel
    {
        public FlowDocument Document { get; set; } = new();
        public LogShowState Show { get; } = new();

        private readonly ILogBlock _block;

        private readonly Dictionary<LogType, Action<ILogEvent>> _lookup;

        public LogDocumentModel(ILogBlock block)
        {
            _block = block;

            _lookup = new Dictionary<LogType, Action<ILogEvent>>
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
        }

        public void AddRange(IEnumerable<ILogEvent> list)
        {
            foreach (var e in list)
            {
                Add(e);
            }
        }

        public void Add(ILogEvent e)
        {
            _lookup[e.LogType](e);
        }

        private void Add(Block block)
        {
            Document.Blocks.Add(block);
        }
    }

    public class NullLogDocumentModel : ILogDocumentModel
    {
        public FlowDocument Document { get; set; } = new();
        public LogShowState Show { get; } = new();

        public void Information(ILogEvent e) => throw new System.NotImplementedException();
        public void Error(ILogEvent e) => throw new System.NotImplementedException();
        public void Exception(ILogEvent e) => throw new System.NotImplementedException();
        public void Add(ILogEvent e) => throw new NotImplementedException();
        public void AddRange(IEnumerable<ILogEvent> e) => throw new NotImplementedException();
        public void Reset() => throw new System.NotImplementedException();
    }
}
