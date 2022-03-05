using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Main.Menu;
using RenderEngineDesktop.Models.Application;
using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Views.ListEnumeratedFonts;
using RenderEngineDesktop.Views.Logging;
using RenderEngineDesktop.Views.Options;
using RenderEngineDesktop.Views.PrepZipDirectoryForParse;
using RenderEngineDesktop.Views.RenderLeads;
using RenderEngineDesktop.Views.RenderLowResPreview;
using RenderEngineDesktop.Views.RenderOutputFiles;
using RenderEngineDesktop.Views.RenderOutputFilesWithWatermark;
using RenderEngineDesktop.Views.RenderPreview;
using RenderEngineDesktop.Views.RenderPreviewHtml5;
using RenderEngineDesktop.Views.RenderWatermarkedPreview;
using RenderEngineDesktop.Views.RenderZoomedPreviewFragment;

namespace RenderEngineDesktop.Main
{
    /// <summary>
    /// The Main window's view-model.  It defines all child-tab view-models.
    /// </summary>
    public class MainViewModel
    {
        public ApplicationModel Settings { get; set; }
        public ConfigurationModel Model { get; set; }
        public MainMenuViewModel Menu { get; }
        public OptionsViewModel Options { get; }
        public LogViewModel Log { get; }

        public ListEnumeratedFontsViewModel ListEnumeratedFonts { get; }
        public RenderPreviewViewModel RenderPreview { get; }
        public RenderWatermarkedPreviewViewModel RenderWatermarkedPreview { get; }
        public RenderOutputFilesViewModel RenderOutputFiles { get; }
        public RenderOutputFilesWithWatermarkViewModel RenderOutputFilesWithWatermark { get; }
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
        public MainViewModel(IFactory factory, IApplication application, IConfiguration configuration)
        {
            Settings = application.Model;
            Model = configuration.Model;

            Menu = factory.Get<MainMenuViewModel>();
            Options = factory.Get<OptionsViewModel>();
            Log = factory.Get<LogViewModel>();

            ListEnumeratedFonts = factory.Get<ListEnumeratedFontsViewModel>();
            RenderPreview = factory.Get<RenderPreviewViewModel>();
            RenderWatermarkedPreview = factory.Get<RenderWatermarkedPreviewViewModel>();
            RenderOutputFiles = factory.Get<RenderOutputFilesViewModel>();
            RenderOutputFilesWithWatermark = factory.Get<RenderOutputFilesWithWatermarkViewModel>();
            RenderPreviewHtml5 = factory.Get<RenderPreviewHtml5ViewModel>();
            RenderLowResPreview = factory.Get<RenderLowResPreviewViewModel>();
            RenderZoomedPreviewFragment = factory.Get<RenderZoomedPreviewFragmentViewModel>();
            RenderLeads = factory.Get<RenderLeadsViewModel>();
            PrepZipDirectoryForParse = factory.Get<PrepZipDirectoryForParseViewModel>();
        }
    }
}
