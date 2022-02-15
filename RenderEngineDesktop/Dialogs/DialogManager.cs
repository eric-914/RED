using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Main;
using System;
using RenderEngineDesktop.Dialogs.FileError;
using RenderEngineDesktop.Dialogs.ServiceError;

namespace RenderEngineDesktop.Dialogs
{
    internal interface IDialogManager
    {
        void ShowPathError(Exception e, string path, string message, params string[] additional);
        void ShowServiceError(Exception e);
    }

    internal class DialogManager : IDialogManager
    {
        private readonly IFactory _factory;
        private readonly IMainWindow _parent;

        public DialogManager(IFactory factory, IMainWindow parent)
        {
            _factory = factory;
            _parent = parent;
        }

        public void ShowPathError(Exception e, string path, string message, params string[] additional)
        {
            var model = new FileErrorMessageBoxModel(e, path, message, additional);

            var dialog = _factory.Get<FileErrorMessageBox>();

            dialog.ShowDialog(_parent.Window, model);
        }

        public void ShowServiceError(Exception e)
        {
            var model = new ServiceErrorMessageBoxModel(e);

            var dialog = _factory.Get<ServiceErrorMessageBox>();

            dialog.ShowDialog(_parent.Window, model);
        }
    }
}
