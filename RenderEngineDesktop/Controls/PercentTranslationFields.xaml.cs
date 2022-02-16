using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class PercentTranslationFields
    {
        public PercentTranslationFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }
    }
}
