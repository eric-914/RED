using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Process;
using RenderEngineDesktop.Support;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RenderEngineDesktop.Views.RenderPreview
{
    public class RenderPreviewViewModel : BaseServiceViewModel<RenderPreviewModel>
    {
        public RenderPreviewViewModel() { }

        [Ninject.Inject]
        public RenderPreviewViewModel(ICommands commands, IBitmapTools tools)
            : base(x => x.RenderPreview)
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
