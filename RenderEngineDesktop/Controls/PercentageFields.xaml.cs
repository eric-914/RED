using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class PercentageFields 
    {
        public PercentageFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }
    }
}
