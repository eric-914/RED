using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Controls;
using RenderEngineDesktop.Models;
using RenderEngineDesktop.Models.Common;
using System.Windows.Input;

namespace RenderEngineDesktop.Views.RenderPreviewHtml5
{
    public class RenderPreviewHtml5ViewModel : NotifyModel
    {
        public RenderPreviewHtml5Model Model { get; }
        public ICommand InvokeCommand { get; }

        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public RenderPreviewHtml5ViewModel()
        {
            Model = new RenderPreviewHtml5Model();
        }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public RenderPreviewHtml5ViewModel(ICommands commands, IConfiguration configuration)
        {
            Model = configuration.Model.RenderPreviewHtml5;

            InvokeCommand = commands.RenderPreviewHtml5Command(x => Url = x);
        }

        private string _document = HtmlViewer.EmptyDocument;
        public string Document
        {
            get => _document;
            set => Set(_document == value, () => _document = value);
        }

        private string _url = string.Empty;
        public string Url
        {
            get => _url;
            set => Set(_url == value, () => _url = value);
        }
    }
}
