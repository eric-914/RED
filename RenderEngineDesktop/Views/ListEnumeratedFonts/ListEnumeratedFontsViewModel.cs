using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Service;
using System.Windows.Input;

namespace RenderEngineDesktop.Views.ListEnumeratedFonts
{
    public class ListEnumeratedFontsViewModel : BaseViewModel
    {
        private readonly IRenderEngine _re;

        public ICommand InvokeCommand { get; }

        #region XAML Design

        //--Used by the XAML designer
#pragma warning disable CS8618
        public ListEnumeratedFontsViewModel() { }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public ListEnumeratedFontsViewModel(ICommands commands, IRenderEngine re)
        {
            _re = re;
            InvokeCommand = commands.Action(Invoke);
        }

        private string _result = string.Empty;
        public string Result
        {
            get => _result;
            set
            {
                if (_result == value) return;

                _result = value;
                OnPropertyChanged();
            }
        }

        private async void Invoke()
        {
            Result = await _re.ListEnumeratedFontsAsync();
        }
    }
}
