using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Configuration.Support;
using RenderEngineDesktop.Dialogs;
using RenderEngineDesktop.Models.Logging;
using RenderEngineDesktop.Service;
using RenderEngineDesktop.Support;
using RenderEngineDesktop.Views.Logging;

namespace RenderEngineDesktop.IoC
{
    /// <summary>
    /// Defines all IoC factory bindings
    /// </summary>
    public static class Bindings
    {
        /// <summary>
        /// Configure the IoC factory with this application's required bindings
        /// </summary>
        public static void Configure()
        {
            Factory.Instance
                .SelfBind()

                .Bind<ILogBlock, LogBlock>()
                .Bind<ILogDocumentModel, LogDocumentModel>()
                .Singleton<ILogger, Logger>()

                .Bind<IRenderEngineService, RenderEngineService>()
                .Bind<IRenderEngine, RenderEngine>()

                .Bind<ISystemInformation, SystemInformation>()
                .Bind<IBitmapTools, BitmapTools>()
                .Bind<IDialogManager, DialogManager>()

                //--Configuration
                .Bind<IConfigurationPersistence, ConfigurationPersistence>()
                .Bind<IConfigurationManager, ConfigurationManager>()
                .Singleton<IConfiguration, ConfigurationInstance>()

                //--Commands
                .Bind<ICommands, CommandsFactory>()

                //--Main
                ;
        }
    }
}
