namespace RenderEngineDesktop.Views.Logging
{
    public partial class LogView 
    {
        public LogView()
        {
            InitializeComponent();
        }

        public LogView(LogViewModel vm) : this()
        {
            DataContext = vm;
        }
    }
}
