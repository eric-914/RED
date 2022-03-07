using RenderEngineDesktop.Service.Parameters.Models;
using System.Windows;

namespace RenderEngineDesktop.Controls
{
    public partial class BrowsePath 
    {
        public BrowsePath()
        {
            InitializeComponent();
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
