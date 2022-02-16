using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class PathFields
    {
        public PathFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }
    }
}
