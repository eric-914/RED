using System.Windows;

namespace RenderEngineDesktop
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IoC.Bindings.Configure();
        }
    }
}
