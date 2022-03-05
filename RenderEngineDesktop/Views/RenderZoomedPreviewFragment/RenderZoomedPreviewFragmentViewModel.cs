using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Models.Process;
using RenderEngineDesktop.Support;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RenderEngineDesktop.Views.RenderZoomedPreviewFragment
{
    public class RenderZoomedPreviewFragmentViewModel : BaseServiceViewModel<RenderZoomedPreviewFragmentModel>
    {
        public RenderZoomedPreviewFragmentViewModel() { }

        [Ninject.Inject]
        public RenderZoomedPreviewFragmentViewModel(ICommands commands, IConfiguration configuration, IBitmapTools tools)
        : base(configuration.Model.RenderZoomedPreviewFragment)
        {
            SetInvoke(commands.RenderZoomedPreviewFragmentCommand(image => Image = image));
            _image = tools.NoImage();
        }

        private ImageSource _image = new BitmapImage();
        public ImageSource Image
        {
            get => _image;
            set => Set(_image == value, () => _image = value);
        }
    }
}
