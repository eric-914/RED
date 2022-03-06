using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Dialogs;
using RenderEngineDesktop.Models.Application;
using RenderEngineDesktop.Models.Application.Support;
using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Models.Configuration.Support;
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
                .Singleton<LogShowState>()

                .Bind<IRenderEngineService, RenderEngineService>()
                .Bind<IRenderEngine, RenderEngine>()

                .Bind<ISystemInformation, SystemInformation>()
                .Bind<IBitmapTools, BitmapTools>()
                .Bind<IDialogManager, DialogManager>()

                //--Application
                .Bind<IApplicationPersistence, ApplicationPersistence>()
                .Bind<IApplicationManager, ApplicationManager>()
                .Singleton<IApplication, ApplicationInstance>()

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
