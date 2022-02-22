using System.Windows.Controls;
using System.Windows.Input;

namespace RenderEngineDesktop.Support
{
    public static class Extensions
    {
        /// <summary>
        /// Execute an update a (vertical) scroll-viewer for a mouse-wheel event
        /// </summary>
        public static void VScroll(this ScrollViewer sender, MouseWheelEventArgs e)
        {
            sender.ScrollToVerticalOffset(sender.VerticalOffset - e.Delta);
            e.Handled = true;
        }
    }
}
