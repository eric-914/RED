using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class CultureFields 
    {
        public CultureFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }
    }
}
