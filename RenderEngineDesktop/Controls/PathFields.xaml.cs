﻿namespace RenderEngineDesktop.Controls
{
    public partial class PathFields
    {
        public PathFields()
        {
            InitializeComponent();
        }

        public object Label
        {
            set => LabelControl.Content = value;
        }

    }
}
