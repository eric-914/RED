using RenderEngineDesktop.IoC;
using System.Windows;

namespace RenderEngineDesktop.Dialogs.ServiceError
{
    public partial class ServiceErrorMessageBox 
    {
        private ServiceErrorMessageBoxViewModel ViewModel
        {
            get => (ServiceErrorMessageBoxViewModel)DataContext;
            init => DataContext = value;
        }

        #region XAML Design

        //--Used by XAML Designer
#pragma warning disable CS8618
        public ServiceErrorMessageBox()
        {
            InitializeComponent();
        }
#pragma warning restore CS8618

        #endregion

        [Ninject.Inject]
        public ServiceErrorMessageBox(IFactory factory) : this()
        {
            var vm = factory.Get<ServiceErrorMessageBoxViewModel>();
            vm.Close += (_, _) => Close();

            ViewModel = vm;
        }

        internal void ShowDialog(Window owner, ServiceErrorMessageBoxModel model)
        {
            Owner = owner;

            ViewModel.Model = model;

            ShowDialog();
        }
    }
}
