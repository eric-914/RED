using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Models.Application;
using System.Windows;

namespace RenderEngineDesktop.Main
{
    public interface IMainWindow
    {
        Window Window { get; }
    }

    public partial class MainWindow : IMainWindow
    {
        public Window Window => this;

        public MainWindow()
        {
            var factory = Factory.Instance;

            factory.Singleton<IMainWindow>(this);

            var application = factory.Get<IApplication>();
            
            application.Load();

            Window.Closed += (_, _) => application.Save();

            InitializeComponent();

            DataContext = factory.Get<MainViewModel>();
        }
    }
}
