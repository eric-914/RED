namespace RenderEngineDesktop.Controls
{
    public partial class SizeFields
    {
        public SizeFields()
        {
            InitializeComponent();
        }

        public object Label
        {
            set => LabelControl.Content = value;
        }
    }
}
