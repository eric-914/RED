using RenderEngineDesktop.Converters;
using System.Windows;
using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class BusyIndicator 
    {
        public BusyIndicator()
        {
            InitializeComponent();
        }

        public string CommandName
        {
            set
            {
                var binding = new Binding("Visibility")
                {
                    ElementName = value,
                    Path = new PropertyPath("IsEnabled"),
                    Converter = new BooleanToVisibilityInverseConverter()
                };

                SetBinding(VisibilityProperty, binding);
            }
        }
    }
}
