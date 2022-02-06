using RenderEngineDesktop.IoC;
using System.Windows;

namespace RenderEngineDesktop.Dialogs
{
    public partial class FileErrorMessageBox
    {
        private FileErrorMessageBoxViewModel ViewModel
        {
            get => (FileErrorMessageBoxViewModel)DataContext;
            init => DataContext = value;
        }

        #region XAML Design

        //--Used by XAML Designer
#pragma warning disable CS8618
        public FileErrorMessageBox()
        {
            InitializeComponent();
        }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public FileErrorMessageBox(IFactory factory) : this()
        {
            var vm = factory.Get<FileErrorMessageBoxViewModel>();
            vm.Close += (_, _) => Close();

            ViewModel = vm;
        }

        internal void ShowDialog(Window owner, FileErrorMessageBoxModel model)
        {
            Owner = owner;

            ViewModel.Model = model;

            ShowDialog();
        }
    }
}
