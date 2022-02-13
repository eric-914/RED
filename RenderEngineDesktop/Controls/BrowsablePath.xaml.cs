using System.Windows;
using System.Windows.Data;
using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Models.Common;
using RenderEngineDesktop.Support;

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
                Factory.Instance.Get<ISystemInformation>().OpenExplorer(model.Path);
            }
        }
    }
}
