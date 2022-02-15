using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Common;
using System.Windows.Input;

namespace RenderEngineDesktop.Views.ListEnumeratedFonts
{
    public class ListEnumeratedFontsViewModel : NotifyModel
    {
        public ICommand InvokeCommand { get; }

        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public ListEnumeratedFontsViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public ListEnumeratedFontsViewModel(ICommands commands)
        {
            InvokeCommand = commands.ListEnumeratedFontsCommand(x => Result = x);
        }

        private string _result = string.Empty;
        public string Result
        {
            get => _result;
            set => Set(_result == value, () => _result = value);
        }
    }
}
