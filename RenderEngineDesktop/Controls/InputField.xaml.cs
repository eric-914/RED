using System.Windows.Controls;
using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class InputField 
    {
        public InputField()
        {
            InitializeComponent();
        }

        public object Label
        {
            set => LabelControl.Content = value;
        }

        public double LabelWidth
        {
            set => LabelControl.Width = value;
        }

        public double TextWidth
        {
            set => TextBoxControl.Width = value;
        }

        public Orientation Orientation
        {
            set => StackPanelControl.Orientation = value;
        }

        public Binding Field
        {
            set => TextBoxControl.SetBinding(TextBox.TextProperty, value);
        }
    }
}
