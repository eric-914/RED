using RenderEngineDesktop.Service.Parameters.Groupings;
using System.Windows;
using System.Windows.Data;

namespace RenderEngineDesktop.Views
{
    public partial class RenderEngineFields 
    {
        public RenderEngineFields()
        {
            InitializeComponent();
        }

        public Binding Context
        {
            set
            {
                void Bind<T>(UIElement control) => control.Visibility = DataContext is T ? Visibility.Visible : Visibility.Collapsed;

                SetBinding(DataContextProperty, value);

                Bind<ISource>(SourceFields);
                Bind<ITemplate>(TemplateFields);
                Bind<IOutputFile>(OutputFileFields);
                Bind<IOutputFiles>(OutputFilesFields);
                Bind<IZipFile>(ZipFileFields);
                Bind<IMaximumInPixels>(MaximumInPixelsFields);
                Bind<IOutlineColorComponent>(OutlineColorComponentFields);
                Bind<IWatermark>(WatermarkFields);
                Bind<ICulture>(CultureFields);
                Bind<IPercentTranslation>(PercentTranslationFields);
                Bind<IPercentage>(PercentageFields);
            }
        }
    }
}
