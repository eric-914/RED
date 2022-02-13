using RenderEngineDesktop.Models.Common;
using System.Windows;
using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    /// <summary>
    /// Interaction logic for BrowsablePath.xaml
    /// </summary>
    public partial class BrowsablePath
    {
        public BrowsablePath()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }

        private void Browse(object sender, RoutedEventArgs e)
        {
            if (DataContext is PathModel model)
            {
                model.Browse();
            }
        }
    }
}
