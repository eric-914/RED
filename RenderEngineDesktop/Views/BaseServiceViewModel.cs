using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Common;
using System.Windows.Input;

namespace RenderEngineDesktop.Views
{
    public abstract class BaseServiceViewModel<T> : NotifyModel
        where T : class, new()
    {
        public T Model { get; } = new();
        public ICommand InvokeCommand { get; private set; } = new NullCommand();

        protected BaseServiceViewModel() { }

        protected BaseServiceViewModel(T model)
        {
            Model = model;
        }

        protected void SetInvoke(ICommand command) => InvokeCommand = command;
    }
}
