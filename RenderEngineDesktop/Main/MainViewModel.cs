using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Views;
using RenderEngineDesktop.Views.ListEnumeratedFonts;
using RenderEngineDesktop.Views.Options;
using RenderEngineDesktop.Views.RenderOutputFiles;
using RenderEngineDesktop.Views.RenderPreview;
using RenderEngineDesktop.Views.RenderPreviewHtml5;

namespace RenderEngineDesktop.Main
{
    public class MainViewModel : BaseViewModel
    {
        public ConfigurationModel Model { get; set; }
        public OptionsViewModel Options { get; }
        public ListEnumeratedFontsViewModel ListEnumeratedFonts { get; }
        public RenderPreviewViewModel RenderPreview { get; }
        public RenderOutputFilesViewModel RenderOutputFiles { get; }
        public RenderPreviewHtml5ViewModel RenderPreviewHtml5 { get; }

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
            RenderOutputFiles = factory.Get<RenderOutputFilesViewModel>();
            RenderPreviewHtml5 = factory.Get<RenderPreviewHtml5ViewModel>();
        }
    }
}
