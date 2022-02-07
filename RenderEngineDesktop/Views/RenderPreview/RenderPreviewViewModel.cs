using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Models;
using RenderEngineDesktop.Service;
using RenderEngineDesktop.Support;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace RenderEngineDesktop.Views.RenderPreview
{
    public class RenderPreviewViewModel : BaseViewModel
    {
        private readonly IRenderEngine _re;
        private readonly IBitmapTools _tools;

        public RenderPreviewModel Model { get; }
        public ICommand InvokeCommand { get; }

        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public RenderPreviewViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public RenderPreviewViewModel(ICommands commands, IRenderEngine re, IConfiguration configuration, IBitmapTools tools)
        {
            _re = re;
            _tools = tools;

            Model = configuration.Model.RenderPreview;
            InvokeCommand = commands.Action(Invoke);

            _image = _tools.CreateBlankImage(2, 2);
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

        private async void Invoke()
        {
            byte[] bmp;

            try
            {
                bmp = await _re.RenderPreviewAsync(Model);
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected connection failure");
                return;
            }

            if (bmp == null || bmp.Length == 0)
            {
                MessageBox.Show("No image data returned");
                return;
            }

            Image = _tools.ToBitmapImage(bmp);
        }
    }
}
