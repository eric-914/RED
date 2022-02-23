using RenderEngineDesktop.Models.Logging;
using RenderEngineDesktop.Service.Parameters.Models;
using System.Windows.Documents;

namespace RenderEngineDesktop.Views.Logging
{
    public class LogViewModel : NotifyModel
    {
        public FlowDocument Document { get; set; } = new();

        #region XAML Design

        //--Used by XAML Designer
#pragma warning disable CS8618
        public LogViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public LogViewModel(ILogger logger)
        {
            logger.LoggedInformation += LoggedInformationEventHandler;
            logger.LoggedError += LoggedErrorEventHandler;
            logger.LoggedException += LoggedExceptionEventHandler;

            logger.LogInformation("Logging started.");
        }

        private void Add(Inline inline) => Document.Blocks.Add(new Paragraph(inline));
        
        private void LoggedInformationEventHandler(object sender, LoggedInformationEventArgs e)
        {
            var message = new Run(e.Message);

            Add(message);
        }

        private void LoggedErrorEventHandler(object sender, LoggedErrorEventArgs e)
        {
            var message = new Run(e.Message);

            Add(message);
        }

        private void LoggedExceptionEventHandler(object sender, LoggedExceptionEventArgs e)
        {
            var message = new Run(e.Message);

            Add(message);
        }
    }
}
