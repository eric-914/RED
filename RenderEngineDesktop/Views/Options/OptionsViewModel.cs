using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Controls;
using RenderEngineDesktop.Models.Application;
using RenderEngineDesktop.Service.Parameters.Models;
using System.Windows.Input;

namespace RenderEngineDesktop.Views.Options;

public class OptionsViewModel : NotifyModel
{
    public ApplicationModel Settings { get; } 

    public EnvironmentSelectViewModel EnvironmentSelect { get; } = new ();

    public ICommand TestCommand { get; }

    #region XAML Design

    //--Used by the XAML designer
#pragma warning disable CS8618
    public OptionsViewModel() { }
#pragma warning restore CS8618

    #endregion

    [Ninject.Inject]
    public OptionsViewModel(ICommands commands, IApplication application)
    {
        Settings = application.Model;
        TestCommand = commands.Test;

        EnvironmentSelect.PropertyChanged += (_, _) => SetEnvironment();
        SetEnvironment();
    }

    private void SetEnvironment()
    {
        Settings.SetEnvironment(EnvironmentSelect.Environments.Selected);

        OnPropertyChanged(nameof(Settings));
    }
}
