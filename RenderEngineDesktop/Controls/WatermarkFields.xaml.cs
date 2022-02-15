using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class WatermarkFields 
    {
        public WatermarkFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }
    }
}
