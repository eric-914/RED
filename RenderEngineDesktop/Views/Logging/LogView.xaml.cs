using Ninject;

namespace RenderEngineDesktop.Views.Logging
{
    public partial class LogView 
    {
        public LogView()
        {
            InitializeComponent();
        }

        [Inject]
        public LogView(LogViewModel vm) : this()
        {
            DataContext = vm;
        }
    }
}
