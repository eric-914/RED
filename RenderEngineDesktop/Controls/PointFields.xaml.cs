namespace RenderEngineDesktop.Controls
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
