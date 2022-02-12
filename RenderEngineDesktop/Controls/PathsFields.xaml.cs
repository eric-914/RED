using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class PathsFields
    {
        public PathsFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }
    }
}
