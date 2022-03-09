namespace RenderEngineDesktop.Controls.Fields
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
