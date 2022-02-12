using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class OutlineColorComponentFields 
    {
        public OutlineColorComponentFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }
    }
}
