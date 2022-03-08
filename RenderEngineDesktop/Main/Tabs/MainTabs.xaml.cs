using RenderEngineDesktop.Support;
using System.Windows.Controls;
using System.Windows.Input;

namespace RenderEngineDesktop.Main.Tabs
{
    public partial class MainTabs 
    {
        public MainTabs()
        {
            InitializeComponent();
        }

        private void UIElement_OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (sender is ScrollViewer s)
            {
                s.VScroll(e);
            }
        }
    }
}
