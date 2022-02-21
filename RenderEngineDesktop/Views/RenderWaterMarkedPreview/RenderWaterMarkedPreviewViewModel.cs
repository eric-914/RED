using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
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
        public RenderWatermarkedPreviewViewModel(ICommands commands, IConfiguration configuration, IBitmapTools tools)
        : base(configuration.Model.RenderWatermarkedPreview)
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
