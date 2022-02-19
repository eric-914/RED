using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Views.ListEnumeratedFonts;
using RenderEngineDesktop.Views.Options;
using RenderEngineDesktop.Views.PrepZipDirectoryForParse;
using RenderEngineDesktop.Views.RenderLeads;
using RenderEngineDesktop.Views.RenderLowResPreview;
using RenderEngineDesktop.Views.RenderOutputFiles;
using RenderEngineDesktop.Views.RenderOutputFilesWithWaterMark;
using RenderEngineDesktop.Views.RenderPreview;
using RenderEngineDesktop.Views.RenderPreviewHtml5;
using RenderEngineDesktop.Views.RenderWaterMarkedPreview;
using RenderEngineDesktop.Views.RenderZoomedPreviewFragment;

namespace RenderEngineDesktop.Main
{
    public class MainViewModel
    {
        public ConfigurationModel Model { get; set; }
        public OptionsViewModel Options { get; }
        public ListEnumeratedFontsViewModel ListEnumeratedFonts { get; }
        public RenderPreviewViewModel RenderPreview { get; }
        public RenderWaterMarkedPreviewViewModel RenderWaterMarkedPreview { get; }
        public RenderOutputFilesViewModel RenderOutputFiles { get; }
        public RenderOutputFilesWithWaterMarkViewModel RenderOutputFilesWithWaterMark { get; }
        public RenderLowResPreviewViewModel RenderLowResPreview { get; }
        public RenderPreviewHtml5ViewModel RenderPreviewHtml5 { get; }
        public RenderZoomedPreviewFragmentViewModel RenderZoomedPreviewFragment { get; }
        public RenderLeadsViewModel RenderLeads { get; }
        public PrepZipDirectoryForParseViewModel PrepZipDirectoryForParse { get; }

        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public MainViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public MainViewModel(IFactory factory, IConfiguration configuration)
        {
            Model = configuration.Model;

            Options = factory.Get<OptionsViewModel>();
            ListEnumeratedFonts = factory.Get<ListEnumeratedFontsViewModel>();
            RenderPreview = factory.Get<RenderPreviewViewModel>();
            RenderWaterMarkedPreview = factory.Get<RenderWaterMarkedPreviewViewModel>();
            RenderOutputFiles = factory.Get<RenderOutputFilesViewModel>();
            RenderOutputFilesWithWaterMark = factory.Get<RenderOutputFilesWithWaterMarkViewModel>();
            RenderPreviewHtml5 = factory.Get<RenderPreviewHtml5ViewModel>();
            RenderLowResPreview = factory.Get<RenderLowResPreviewViewModel>();
            RenderZoomedPreviewFragment = factory.Get<RenderZoomedPreviewFragmentViewModel>();
            RenderLeads = factory.Get<RenderLeadsViewModel>();
            PrepZipDirectoryForParse = factory.Get<PrepZipDirectoryForParseViewModel>();
        }
    }
}
