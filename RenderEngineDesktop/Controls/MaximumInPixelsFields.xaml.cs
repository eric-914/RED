﻿using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    public partial class MaximumInPixelsFields
    {
        public MaximumInPixelsFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set => SetBinding(DataContextProperty, value);
        }
    }
}
