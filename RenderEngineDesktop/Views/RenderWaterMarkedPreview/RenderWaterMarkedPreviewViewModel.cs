using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Process;
using RenderEngineDesktop.Support;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RenderEngineDesktop.Views.RenderWatermarkedPreview
{
    public class RenderWatermarkedPreviewViewModel : BaseServiceViewModel<RenderWatermarkedPreviewModel>
    {
        public RenderWatermarkedPreviewViewModel() { }

        [Ninject.Inject]
        public RenderWatermarkedPreviewViewModel(ICommands commands, IBitmapTools tools)
            : base(x => x.RenderWatermarkedPreview)
        {
            SetInvoke(commands.RenderWatermarkedPreviewCommand(image => Image = image));
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
