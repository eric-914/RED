using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Configuration.Support;
using RenderEngineDesktop.Dialogs;
using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Service;
using System.Windows;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Factory.Instance
                .SelfBind()

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
