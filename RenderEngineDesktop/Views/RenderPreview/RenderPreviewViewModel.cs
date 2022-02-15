using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models;
using RenderEngineDesktop.Support;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RenderEngineDesktop.Views.RenderPreview
{
    public class RenderPreviewViewModel : BaseServiceViewModel<RenderPreviewModel>
    {
        public RenderPreviewViewModel() { }

        [Ninject.Inject]
        public RenderPreviewViewModel(ICommands commands, IConfiguration configuration, IBitmapTools tools)
        : base(configuration.Model.RenderPreview)
        {
            SetInvoke(commands.RenderPreviewCommand(image => Image = image));
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
