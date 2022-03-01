using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class InputField 
    {
        public static readonly DependencyProperty LabelWidthProperty
            = DependencyProperty.Register("LabelWidth", typeof(double), typeof(InputField));

        public static readonly DependencyProperty TextWidthProperty
            = DependencyProperty.Register("TextWidth", typeof(double), typeof(InputField));

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
            //set => LabelControl.Width = value;
            get => (double)GetValue(LabelWidthProperty);
            set => SetValue(LabelWidthProperty, value);
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            if (e.Property == LabelWidthProperty)
            {
                LabelControl.Width = LabelWidth;
            } else if (e.Property == TextWidthProperty)
            {
                TextBoxControl.Width = TextWidth;
            }
        }

        public double TextWidth
        {
            //set => TextBoxControl.Width = value;
            get => (double)GetValue(TextWidthProperty);
            set => SetValue(TextWidthProperty, value);

        }

        public Orientation Orientation
        {
            set => StackPanelControl.Orientation = value;
        }

        public Binding Text
        {
            set => TextBoxControl.SetBinding(TextBox.TextProperty, value);
        }
    }
}
