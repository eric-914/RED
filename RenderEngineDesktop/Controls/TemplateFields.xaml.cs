using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class TemplateFields 
    {
        public TemplateFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }
    }
}
