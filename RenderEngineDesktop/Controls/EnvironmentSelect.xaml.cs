using System.Linq;
using RenderEngineDesktop.Models;
using RenderEngineDesktop.Models.Environment;
using RenderEngineDesktop.Service.Parameters.Models;

namespace RenderEngineDesktop.Controls
{
    public partial class EnvironmentSelect
    {
        public EnvironmentSelect()
        {
            InitializeComponent();
        }
    }

    public class EnvironmentSelectViewModel : NotifyModel
    {
        public EnvironmentsModel Environments { get; } = new();

        public Environments Selected
        {
            get => Environments.Selected.Environment;
            set
            {
                Environments.Selected = Environments.First(x => x.Environment == value);
                OnPropertyChanged();
            }
        }
    }
}
