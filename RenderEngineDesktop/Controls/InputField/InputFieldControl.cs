using System.Windows;
using System.Windows.Controls;

namespace RenderEngineDesktop.Controls.InputField
{
    public class InputFieldControl : Control
    {
        public static readonly DependencyProperty LabelProperty
        = DependencyProperty.Register(nameof(Label), typeof(string), typeof(InputFieldControl),
            new PropertyMetadata(default(string)));

        public static readonly DependencyProperty LabelWidthProperty
        = DependencyProperty.Register(nameof(LabelWidth), typeof(double), typeof(InputFieldControl),
            new PropertyMetadata(default(double)));

        public static readonly DependencyProperty TextProperty
        = DependencyProperty.Register(nameof(Text), typeof(string), typeof(InputFieldControl),
            new PropertyMetadata(default(string)));

        public static readonly DependencyProperty TextWidthProperty
            = DependencyProperty.Register(nameof(TextWidth), typeof(double), typeof(InputFieldControl),
                new PropertyMetadata(default(double)));

        public string Label
        {
            get => (string) GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public double LabelWidth
        {
            get => (double)GetValue(LabelWidthProperty);
            set => SetValue(LabelWidthProperty, value);
        }

        public string Text
        {
            get => (string) GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public double TextWidth
        {
            get => (double)GetValue(TextWidthProperty);
            set => SetValue(TextWidthProperty, value);
        }
    }
}
