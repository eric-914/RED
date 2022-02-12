using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class SourceFields 
    {
        public SourceFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }
    }
}
