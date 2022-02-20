using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models.Process;
using RenderEngineDesktop.Support;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RenderEngineDesktop.Views.RenderWaterMarkedPreview
{
    public class RenderWaterMarkedPreviewViewModel : BaseServiceViewModel<RenderWaterMarkedPreviewModel>
    {
        public RenderWaterMarkedPreviewViewModel() { }

        [Ninject.Inject]
        public RenderWaterMarkedPreviewViewModel(ICommands commands, IConfiguration configuration, IBitmapTools tools)
        : base(configuration.Model.RenderWaterMarkedPreview)
        {
            SetInvoke(commands.RenderWaterMarkedPreviewCommand(image => Image = image));
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
