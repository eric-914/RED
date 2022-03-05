using System;
using System.Windows.Input;

namespace RenderEngineDesktop.Models.SavedState
{
    public class SavedStateModel
    {
        public ICommand Load1 { get; } = default!;
        public ICommand Load2 { get; } = default!;
        public ICommand Load3 { get; } = default!;
        public ICommand Load4 { get; } = default!;

        public SavedStateModel() { }

        public SavedStateModel(Func<ICommand> create)
        {
            Load1 = create();
            Load2 = create();
            Load3 = create();
            Load4 = create();
        }
    }
}
