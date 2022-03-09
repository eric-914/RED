namespace RenderEngineDesktop.Controls.Fields
{
    public partial class PointFields
    {
        public PointFields()
        {
            InitializeComponent();
        }

        public object Label
        {
            set => LabelControl.Content = value;
        }
    }
}
