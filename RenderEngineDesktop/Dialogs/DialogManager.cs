using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Main;
using System;

namespace RenderEngineDesktop.Dialogs
{
    internal interface IDialogManager
    {
        void ShowPathError(Exception e, string path, string message, params string[] additional);
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
    }
}
