using RenderEngineDesktop.Models.Logging;
using System.Windows.Documents;
using System.Windows.Media;

namespace RenderEngineDesktop.Views.Logging
{
    public interface ILogBlock
    {
        Block Information(ILogEvent e);
        Block Error(ILogEvent e);
        Block Exception(ILogEvent e);
    }

    public class LogBlock : ILogBlock
    {
        public Block Information(ILogEvent e)
        {
            return Block(LogColors.Information, new Run(e.Message));
        }

        public Block Error(ILogEvent e)
        {
            return Block(LogColors.Error, new Run(e.Message));
        }

        public Block Exception(ILogEvent e)
        {
            if (e.Exception == null)
            {
                return Block(LogColors.Exception, new Run(e.Message));
            }

            if (string.IsNullOrEmpty(e.Message))
            {
                return Block(LogColors.Exception, new Run(e.Exception.Message));
            }

            var span = new Span();
            span.Inlines.Add(new Run(e.Message));
            span.Inlines.Add(new LineBreak());
            span.Inlines.Add(new Run(e.Exception.Message));

            return Block(LogColors.Exception, span);
        }

        private static Block Block(Brush color, Inline inline)
        {
            return new Paragraph(inline)
            {
                Foreground = color
            };
        }
    }
}
