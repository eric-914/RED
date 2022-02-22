using System.Windows.Controls;
using System.Windows.Input;
using RenderEngineDesktop.Support;

namespace RenderEngineDesktop.Views.ListEnumeratedFonts
{
    public partial class ListEnumeratedFontsView
    {
        public ListEnumeratedFontsView()
        {
            InitializeComponent();
        }

        //--Without this, the mouse wheel only works while over the scrollbar.
        private void UIElement_OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ((ScrollViewer)sender).VScroll(e);
        }
    }
}
