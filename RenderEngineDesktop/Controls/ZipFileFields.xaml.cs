using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class ZipFileFields 
    {
        public ZipFileFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }
    }
}
