namespace RenderEngineDesktop.Views.RenderPreview
{
    public partial class RenderPreviewView
    {
        public RenderPreviewView()
        {
            DataContext = new RenderPreviewViewModel();

            InitializeComponent();
        }
    }
}
