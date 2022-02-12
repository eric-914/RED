using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models;
using RenderEngineDesktop.Support;
using System.Windows.Input;
using System.Windows.Media;

namespace RenderEngineDesktop.Views.RenderPreview
{
    public class RenderPreviewViewModel : BaseViewModel
    {
        public RenderPreviewModel Model { get; }
        public ICommand InvokeCommand { get; }

        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public RenderPreviewViewModel()
        {
            Model = new RenderPreviewModel();
        }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public RenderPreviewViewModel(ICommands commands, IConfiguration configuration, IBitmapTools tools)
        {
            Model = configuration.Model.RenderPreview;
            
            InvokeCommand = commands.RenderPreviewCommand(image => Image = image);

            _image = tools.CreateBlankImage(2, 2);
        }

        private ImageSource _image;
        public ImageSource Image
        {
            get => _image;
            set
            {
                if (_image == value) return;

                _image = value;
                OnPropertyChanged();
            }
        }
    }
}
