using System.IO;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;

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

        public static void Configure(this FileDialog source, string path, FileExtension extension)
        {
            source.FileName = Path.GetFileName(path);
            source.InitialDirectory = Path.GetDirectoryName(path);
            source.Filter = extension.Filter;
        }
    }
}
